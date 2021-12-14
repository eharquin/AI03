using System;
using System.Collections.Generic;
using System.Linq;
using Lidgren.Network;
using Microsoft.Xna.Framework.Input;
using PongLibrary;
using PongServer.Commands;
using PongServer.Manager;
using PongServer.Util;

namespace PongServer
{
    public class Server
    {
        private NetServer _server;
        private List<Player> _players;

        private ManagerLogger _managerLogger;

        public Server(ManagerLogger managerLogger)
        {
            _players = new List<Player>();
            _managerLogger = managerLogger;
            var config = new NetPeerConfiguration("Pong");
            _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "Set applIdentifier to \"Pong\"");

            config.Port = 14241;
            _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "Set server port to 14241");

            config.SimulatedMinimumLatency = 0.200f;
            _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "Set server SimulatedMinimumLatency to 200ms");

            config.EnableMessageType(NetIncomingMessageType.ConnectionApproval);
            _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "Enable message type NetIncomingMessageType.ConnectionApproval");


            _server = new NetServer(config);
        }


        public void Run()
        {
            _server.Start();
            _managerLogger.AddLogMessage(LogCategory.Info, "Server", "Server started...");


            while (true)
            {

                NetIncomingMessage inc = _server.ReadMessage();

                if (inc == null) continue;

                _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "Message receive: " + inc.MessageType.ToString());

                switch (inc.MessageType)
                {
                    case NetIncomingMessageType.Error:
                        _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "Error: " + inc.ReadString());
                        break;
                    case NetIncomingMessageType.DebugMessage:
                        _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "DebugMessage: " + inc.ReadString());
                        break;
                    case NetIncomingMessageType.StatusChanged:
                        StatusChangedMessage(inc);
                        break;
                    case NetIncomingMessageType.ConnectionApproval:
                        var connectionApproval = new ConnectionApprovalCommand();
                        connectionApproval.Run(_server, inc, null, null, 0);
                        break;
                    case NetIncomingMessageType.Data:
                        DataMessage(inc);
                        break;
                    case NetIncomingMessageType.WarningMessage:
                        _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "Warning: " + inc.ReadString());
                        break;
                }
            }
        }

        private void StatusChangedMessage(NetIncomingMessage inc)
        {
            var status = (NetConnectionStatus)inc.ReadByte();
            _managerLogger.AddLogMessage(LogCategory.Debug, "Server", "NetConnectionStatus: " + status.ToString());

            switch (status)
            {
                case NetConnectionStatus.None:
                    break;
                case NetConnectionStatus.InitiatedConnect:
                    break;
                case NetConnectionStatus.ReceivedInitiation:
                    break;
                case NetConnectionStatus.RespondedAwaitingApproval:
                    break;
                case NetConnectionStatus.RespondedConnect:
                    break;
                case NetConnectionStatus.Connected:
                    _managerLogger.AddLogMessage(LogCategory.Debug, "Server", inc.SenderConnection + " is connected. Waiting for login info...");
                    break;
                case NetConnectionStatus.Disconnecting:
                    var command1 = new DisconnectCommand();
                    command1.Run(_server, inc, null, _players, 0);
                    break;
                case NetConnectionStatus.Disconnected:
                    var command = new DisconnectCommand();
                    command.Run(_server, inc, null, _players, 0);
                    break;
            }
        }


        private void DataMessage(NetIncomingMessage inc)
        {
            var packetType = (PacketType)inc.ReadByte();
            var command = CommandFactory.GetCommand(packetType);
            command.Run(_server, inc, null, _players, 0);
        }
    }
}
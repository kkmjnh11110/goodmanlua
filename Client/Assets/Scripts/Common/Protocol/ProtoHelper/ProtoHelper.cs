using Framework;
using System;
using System.Collections.Generic;

public class ProtoHelper
{
    private static Dictionary<int, PacketFactory> _factory = new Dictionary<int, PacketFactory>();

    private static readonly object _thisLock = new object();

    private static void RegisterProto(Type type)
    {
        System.Object target = Activator.CreateInstance(type);
        if (target is Packet)
        {
            Packet packet = target as Packet;
            _factory[packet.GetPacketId()] = new PacketFactory(type);
            ReturnPacket(packet);
        }
        else
        {
            LogHelper.PrintError($"[ProtoHelper]RegisterProto:{type.ToString()} error.");
        }
    }

    public static Packet GetPacket(int type)
    {
        lock (_thisLock)
        {
            if (_factory.ContainsKey(type))
            {
                return _factory[type].GetPacket();
            }
            else
            {
                LogHelper.PrintError($"[ProtoHelper]GetPacket:{type.ToString()} error.");
                return null;
            }
        }
    }

    public static void ReturnPacket(Packet packet)
    {
        lock (_thisLock)
        {
            int type = packet.GetPacketId();
            if (_factory.ContainsKey(type))
            {
                _factory[type].ReturnPacket(packet);
            }
            else
            {
                LogHelper.PrintError($"[ProtoHelper]ReturnPacket:{type.ToString()}!");
            }
        }
    }

    public static void Register()
    {
        _factory.Clear();
        RegisterProto(typeof(Packet_LoginRequest));
        RegisterProto(typeof(Packet_LoginResponse));
    }
}

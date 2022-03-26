using System;

namespace BLE.Abstractions
{
    public struct KnownDescriptor
    {
        public string Name { get; }
        public Guid Id { get; }

        public KnownDescriptor(string name, Guid id)
        {
            Name = name;
            Id = id;
        }
    }
}
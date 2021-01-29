// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.ChannelStreaming
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ChannelStreamingStop : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ChannelStreamingStop"",""namespace"":""Energistics.Protocol.ChannelStreaming"",""fields"":[{""name"":""channels"",""type"":{""type"":""array"",""items"":""long""}}],""messageType"":""5"",""protocol"":""1"",""senderRole"":""consumer"",""protocolRoles"":""producer,consumer"",""fullName"":""Energistics.Protocol.ChannelStreaming.ChannelStreamingStop"",""depends"":[]}");
		private IList<System.Int64> _channels;
		public virtual Schema Schema
		{
			get
			{
				return ChannelStreamingStop._SCHEMA;
			}
		}
		public IList<System.Int64> Channels
		{
			get
			{
				return this._channels;
			}
			set
			{
				this._channels = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channels;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channels = (IList<System.Int64>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

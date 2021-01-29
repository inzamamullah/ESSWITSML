// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.GrowingObject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GrowingObjectGet : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GrowingObjectGet"",""namespace"":""Energistics.Protocol.GrowingObject"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""uid"",""type"":""string""}],""messageType"":""3"",""protocol"":""6"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Protocol.GrowingObject.GrowingObjectGet"",""depends"":[]}");
		private string _uri;
		private string _uid;
		public virtual Schema Schema
		{
			get
			{
				return GrowingObjectGet._SCHEMA;
			}
		}
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public string Uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				this._uid = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._uid;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._uid = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

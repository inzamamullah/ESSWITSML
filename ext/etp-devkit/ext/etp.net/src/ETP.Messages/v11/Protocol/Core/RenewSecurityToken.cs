// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.Core
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class RenewSecurityToken : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""RenewSecurityToken"",""namespace"":""Energistics.Protocol.Core"",""fields"":[{""name"":""token"",""type"":""string""}],""messageType"":""6"",""protocol"":""0"",""senderRole"":""client"",""protocolRoles"":""client,server"",""fullName"":""Energistics.Protocol.Core.RenewSecurityToken"",""depends"":[]}");
		private string _token;
		public virtual Schema Schema
		{
			get
			{
				return RenewSecurityToken._SCHEMA;
			}
		}
		public string Token
		{
			get
			{
				return this._token;
			}
			set
			{
				this._token = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._token;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._token = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

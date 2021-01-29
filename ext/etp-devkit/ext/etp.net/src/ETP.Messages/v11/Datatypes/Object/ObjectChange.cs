// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes.Object
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ObjectChange : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ObjectChange"",""namespace"":""Energistics.Datatypes.Object"",""fields"":[{""name"":""changeType"",""type"":{""type"":""enum"",""name"":""ObjectChangeTypes"",""namespace"":""Energistics.Datatypes.Object"",""symbols"":[""Upsert"",""Delete""],""fullName"":""Energistics.Datatypes.Object.ObjectChangeTypes"",""depends"":[]}},{""name"":""changeTime"",""type"":""long""},{""name"":""dataObject"",""type"":{""type"":""record"",""name"":""DataObject"",""namespace"":""Energistics.Datatypes.Object"",""fields"":[{""name"":""resource"",""type"":{""type"":""record"",""name"":""Resource"",""namespace"":""Energistics.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""name"",""type"":""string""},{""name"":""channelSubscribable"",""type"":""boolean""},{""name"":""customData"",""type"":{""type"":""map"",""values"":""string""}},{""name"":""resourceType"",""type"":""string""},{""name"":""hasChildren"",""type"":""int""},{""name"":""uuid"",""type"":[""null"",""string""]},{""name"":""lastChanged"",""type"":""long""},{""name"":""objectNotifiable"",""type"":""boolean""}],""fullName"":""Energistics.Datatypes.Object.Resource"",""depends"":[]}},{""name"":""contentEncoding"",""type"":""string""},{""name"":""data"",""type"":""bytes""}],""fullName"":""Energistics.Datatypes.Object.DataObject"",""depends"":[
  ""Energistics.Datatypes.Object.Resource""
]}}],""fullName"":""Energistics.Datatypes.Object.ObjectChange"",""depends"":[
  ""Energistics.Datatypes.Object.ObjectChangeTypes"",
  ""Energistics.Datatypes.Object.DataObject""
]}");
		private Energistics.Etp.v11.Datatypes.Object.ObjectChangeTypes _changeType;
		private long _changeTime;
		private Energistics.Etp.v11.Datatypes.Object.DataObject _dataObject;
		public virtual Schema Schema
		{
			get
			{
				return ObjectChange._SCHEMA;
			}
		}
		public Energistics.Etp.v11.Datatypes.Object.ObjectChangeTypes ChangeType
		{
			get
			{
				return this._changeType;
			}
			set
			{
				this._changeType = value;
			}
		}
		public long ChangeTime
		{
			get
			{
				return this._changeTime;
			}
			set
			{
				this._changeTime = value;
			}
		}
		public Energistics.Etp.v11.Datatypes.Object.DataObject DataObject
		{
			get
			{
				return this._dataObject;
			}
			set
			{
				this._dataObject = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._changeType;
			case 1: return this._changeTime;
			case 2: return this._dataObject;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._changeType = (Energistics.Etp.v11.Datatypes.Object.ObjectChangeTypes)fieldValue; break;
			case 1: this._changeTime = (System.Int64)fieldValue; break;
			case 2: this._dataObject = (Energistics.Etp.v11.Datatypes.Object.DataObject)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
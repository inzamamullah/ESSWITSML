// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Uuid : SpecificFixed
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"size\":" +
				"16,\"fullName\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"depends\":[]}");
		private static uint fixedSize = 16;
		public Uuid() : 
				base(fixedSize)
		{
		}
		public override Schema Schema
		{
			get
			{
				return Uuid._SCHEMA;
			}
		}
		public static uint FixedSize
		{
			get
			{
				return Uuid.fixedSize;
			}
		}
	}
}

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcCompressorType : IIfcCompressorType
	{
		Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum IIfcCompressorType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.DYNAMIC:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.DYNAMIC;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.RECIPROCATING:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.RECIPROCATING;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.ROTARY:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.ROTARY;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.SCROLL:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.SCROLL;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.TROCHOIDAL:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.TROCHOIDAL;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.SINGLESTAGE:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.SINGLESTAGE;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.BOOSTER:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.BOOSTER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.OPENTYPE:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.OPENTYPE;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.HERMETIC:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.HERMETIC;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.SEMIHERMETIC:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.SEMIHERMETIC;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.WELDEDSHELLHERMETIC:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.WELDEDSHELLHERMETIC;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.ROLLINGPISTON:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.ROLLINGPISTON;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.ROTARYVANE:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.ROTARYVANE;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.SINGLESCREW:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.SINGLESCREW;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.TWINSCREW:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.TWINSCREW;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.USERDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.HVACDomain.IfcCompressorTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcCompressorTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}
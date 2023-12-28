﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstructionQueryType1Code.  ISO2002 ID# _jjvIle5NEeCisYr99QEiWA_173504363.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of instruction queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jjvIle5NEeCisYr99QEiWA_173504363")]
[Description(@"Specifies the type of instruction queried.")]
[DerivedFrom(typeof(InstructionQueryTypeCode))]
public enum InstructionQueryType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jjvIlu5NEeCisYr99QEiWA_351623035")]
    [Description(@"??")]
    SettlementInstruction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntraPositionMovement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jj4SgO5NEeCisYr99QEiWA_1818771798")]
    [Description(@"??")]
    IntraPositionMovement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAndIntraPosition".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jj4Sge5NEeCisYr99QEiWA_-645449318")]
    [Description(@"??")]
    SettlementAndIntraPosition,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstructionQueryType1CodeMetadataExtensions
{
    private static readonly InstructionQueryType1CodeDropdownSource _dropdownSource = new InstructionQueryType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstructionQueryType1CodeDropdownRow GetMetadata(this InstructionQueryType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


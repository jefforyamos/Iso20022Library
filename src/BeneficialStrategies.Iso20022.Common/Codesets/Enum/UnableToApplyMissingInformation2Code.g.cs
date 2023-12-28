﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnableToApplyMissingInformation2Code.  ISO2002 ID# _Y1ibWdp-Ed-ak6NoX_4Aeg_871704615.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to missing information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y1ibWdp-Ed-ak6NoX_4Aeg_871704615")]
[Description(@"Specifies the reason of an unable to apply due to missing information.")]
[DerivedFrom(typeof(UnableToApplyMissingInformationV2Code))]
public enum UnableToApplyMissingInformation2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlQNp-Ed-ak6NoX_4Aeg_871704646")]
    [Description(@"??")]
    MissingRemittanceInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructionForNextAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlQdp-Ed-ak6NoX_4Aeg_871704647")]
    [Description(@"??")]
    MissingInstructionForNextAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingDebtor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlQtp-Ed-ak6NoX_4Aeg_871704677")]
    [Description(@"??")]
    MissingDebtor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingDebtorAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlQ9p-Ed-ak6NoX_4Aeg_871704678")]
    [Description(@"??")]
    MissingDebtorAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingDebtorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlRNp-Ed-ak6NoX_4Aeg_871704707")]
    [Description(@"??")]
    MissingDebtorAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlRdp-Ed-ak6NoX_4Aeg_871704708")]
    [Description(@"??")]
    MissingAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingSettlementAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlRtp-Ed-ak6NoX_4Aeg_871704709")]
    [Description(@"??")]
    MissingSettlementAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingIntermediary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlR9p-Ed-ak6NoX_4Aeg_871704738")]
    [Description(@"??")]
    MissingIntermediary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructingReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlSNp-Ed-ak6NoX_4Aeg_871704739")]
    [Description(@"??")]
    MissingInstructingReimbursementAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructedReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y1rlSdp-Ed-ak6NoX_4Aeg_871704985")]
    [Description(@"??")]
    MissingInstructedReimbursementAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingThirdReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y11WQNp-Ed-ak6NoX_4Aeg_871704986")]
    [Description(@"??")]
    MissingThirdReimbursementAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCreditor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y11WQdp-Ed-ak6NoX_4Aeg_871704987")]
    [Description(@"??")]
    MissingCreditor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCreditorAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y11WQtp-Ed-ak6NoX_4Aeg_871705016")]
    [Description(@"??")]
    MissingCreditorAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y11WQ9p-Ed-ak6NoX_4Aeg_871705017")]
    [Description(@"??")]
    MissingInstruction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCreditorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y11WRNp-Ed-ak6NoX_4Aeg_928036977")]
    [Description(@"??")]
    MissingCreditorAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructionForCreditorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y11WRdp-Ed-ak6NoX_4Aeg_-2049989314")]
    [Description(@"??")]
    MissingInstructionForCreditorAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructionForDebtorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y11WRtp-Ed-ak6NoX_4Aeg_-2038904858")]
    [Description(@"??")]
    MissingInstructionForDebtorAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnableToApplyMissingInformation2CodeMetadataExtensions
{
    private static readonly UnableToApplyMissingInformation2CodeDropdownSource _dropdownSource = new UnableToApplyMissingInformation2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnableToApplyMissingInformation2CodeDropdownRow GetMetadata(this UnableToApplyMissingInformation2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


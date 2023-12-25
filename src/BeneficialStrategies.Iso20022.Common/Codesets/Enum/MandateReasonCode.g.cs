﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MandateReasonCode.  ISO2002 ID# _af7gkNp-Ed-ak6NoX_4Aeg_-586944687.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for requesting the amendment or cancellation of a mandate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_af7gkNp-Ed-ak6NoX_4Aeg_-586944687")]
[Description(@"Specifies the reason for requesting the amendment or cancellation of a mandate.")]
public enum MandateReasonCode
{
    /// <summary>
    /// Agent details are incorrect or have changed.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_af7gkdp-Ed-ak6NoX_4Aeg_-1939942868")]
    [Description(@"Agent details are incorrect or have changed.")]
    AGNT,
    
    /// <summary>
    /// Currency for the mandate is incorrect or has changed.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_af7gktp-Ed-ak6NoX_4Aeg_-1939942867")]
    [Description(@"Currency for the mandate is incorrect or has changed.")]
    CURR,
    
    /// <summary>
    /// Customer requested the change.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_af7gk9p-Ed-ak6NoX_4Aeg_-1939942838")]
    [Description(@"Customer requested the change.")]
    CUST,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor.
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_af7glNp-Ed-ak6NoX_4Aeg_-1939942807")]
    [Description(@"Insufficient or incoherent details about the debtor.")]
    DBTR,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor.
    /// </summary>
    [EnumMember(Value = "CDTR")]
    [IsoId("_af7gldp-Ed-ak6NoX_4Aeg_-1939942776")]
    [Description(@"Insufficient or incoherent details about the creditor.")]
    CDTR,
    
    /// <summary>
    /// Account details are not correct.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_af7gltp-Ed-ak6NoX_4Aeg_-2096018319")]
    [Description(@"Account details are not correct.")]
    ACCT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MandateReasonCodeMetadataExtensions
{
    private static readonly MandateReasonCodeDropdownSource _dropdownSource = new MandateReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMandateReasonCodeDropdownRow GetMetadata(this MandateReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



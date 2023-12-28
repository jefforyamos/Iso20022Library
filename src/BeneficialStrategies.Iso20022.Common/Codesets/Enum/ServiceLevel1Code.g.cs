﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ServiceLevel1Code.  ISO2002 ID# _ZKZRBtp-Ed-ak6NoX_4Aeg_741883054.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKZRBtp-Ed-ak6NoX_4Aeg_741883054")]
[Description(@"Specifies the pre-agreed level of service between the parties.")]
[DerivedFrom(typeof(ServiceLevelCode))]
public enum ServiceLevel1Code
{
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// Encoded/decoded by serializers as "SingleEuroPaymentsArea".
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_ZKZRB9p-Ed-ak6NoX_4Aeg_798217531")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SingleEuroPaymentsArea,
    
    /// <summary>
    /// Payment must be executed with same day value to the creditor.
    /// Encoded/decoded by serializers as "SameDayValue".
    /// </summary>
    [EnumMember(Value = "SDVA")]
    [IsoId("_ZKZRCNp-Ed-ak6NoX_4Aeg_798217556")]
    [Description(@"Payment must be executed with same day value to the creditor.")]
    SameDayValue,
    
    /// <summary>
    /// Transaction must be processed according to the EBA|Priority Service.
    /// Encoded/decoded by serializers as "EBAPriorityService".
    /// </summary>
    [EnumMember(Value = "PRPT")]
    [IsoId("_ZKjCANp-Ed-ak6NoX_4Aeg_1645064833")]
    [Description(@"Transaction must be processed according to the EBA|Priority Service.")]
    EBAPriorityService,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ServiceLevel1CodeMetadataExtensions
{
    private static readonly ServiceLevel1CodeDropdownSource _dropdownSource = new ServiceLevel1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IServiceLevel1CodeDropdownRow GetMetadata(this ServiceLevel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



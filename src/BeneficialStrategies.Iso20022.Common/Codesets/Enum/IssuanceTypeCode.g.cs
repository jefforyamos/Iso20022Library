﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IssuanceTypeCode.  ISO2002 ID# _Kx1cMH4LEeG05p8M2uqofg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the undertaking issuance type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Kx1cMH4LEeG05p8M2uqofg")]
[Description(@"Specifies the undertaking issuance type.")]
[Derivations(typeof(IssuanceType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum IssuanceTypeCode
{
    /// <summary>
    /// Undertaking issued direct to the beneficiary.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_okhB0H4LEeG05p8M2uqofg")]
    [Description(@"Undertaking issued direct to the beneficiary.")]
    UndertakingIssuedDirect,
    
    /// <summary>
    /// Undertaking issued to the beneficiary via an advising party.
    /// Encoded/decoded by serializers as "ISAD".
    /// </summary>
    [EnumMember(Value = "ISAD")]
    [IsoId("_2S0k4H4LEeG05p8M2uqofg")]
    [Description(@"Undertaking issued to the beneficiary via an advising party.")]
    UndertakingViaAdvisingParty,
    
    /// <summary>
    /// Undertaking issued to the beneficiary via a confirming party.
    /// Encoded/decoded by serializers as "ISCO".
    /// </summary>
    [EnumMember(Value = "ISCO")]
    [IsoId("_-OEkMH4LEeG05p8M2uqofg")]
    [Description(@"Undertaking issued to the beneficiary via a confirming party.")]
    UndertakingIssuedViaConfirmingParty,
    
    /// <summary>
    /// Counter-undertaking issued to a correspondent with a request to issue a local undertaking.
    /// Encoded/decoded by serializers as "CRQL".
    /// </summary>
    [EnumMember(Value = "CRQL")]
    [IsoId("_HetpIH4MEeG05p8M2uqofg")]
    [Description(@"Counter-undertaking issued to a correspondent with a request to issue a local undertaking.")]
    CounterUndertakingRequestForLocalUndertaking,
    
    /// <summary>
    /// Counter-undertaking issued to a correspondent with a request to issue another counter-undertaking.
    /// Encoded/decoded by serializers as "CRQC".
    /// </summary>
    [EnumMember(Value = "CRQC")]
    [IsoId("_cyhlAH4MEeG05p8M2uqofg")]
    [Description(@"Counter-undertaking issued to a correspondent with a request to issue another counter-undertaking.")]
    CounterUndertakingRequestForCounterUndertaking,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IssuanceTypeCodeMetadataExtensions
{
    private static readonly IssuanceTypeCodeDropdownSource _dropdownSource = new IssuanceTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIssuanceTypeCodeDropdownRow GetMetadata(this IssuanceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



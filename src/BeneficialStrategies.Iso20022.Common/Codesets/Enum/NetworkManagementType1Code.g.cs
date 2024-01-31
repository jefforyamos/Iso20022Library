﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NetworkManagementType1Code.  ISO2002 ID# _tr7uoFWPEeeiG_nL4vgKnQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of network management service.
/// ISO 8583 bit 24.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tr7uoFWPEeeiG_nL4vgKnQ")]
[Description(@"Type of network management service.|ISO 8583 bit 24.")]
[DerivedFrom(typeof(NetworkManagementTypeCode))]
public enum NetworkManagementType1Code
{
    /// <summary>
    /// Detects whether communication at application level is still active.
    /// Encoded/decoded by serializers as "ECTS".
    /// </summary>
    [EnumMember(Value = "ECTS")]
    [IsoId("_93b3clWQEeeiG_nL4vgKnQ")]
    [Description(@"Detects whether communication at application level is still active.")]
    EchoTest = NetworkManagementTypeCode.EchoTest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Enable receipt of store and forward advice and notification messages.
    /// Encoded/decoded by serializers as "ESFW".
    /// </summary>
    [EnumMember(Value = "ESFW")]
    [IsoId("_-CvIglWQEeeiG_nL4vgKnQ")]
    [Description(@"Enable receipt of store and forward advice and notification messages.")]
    EnableStoreAndForward = NetworkManagementTypeCode.EnableStoreAndForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of communication management service defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_-MaB4lWQEeeiG_nL4vgKnQ")]
    [Description(@"Other type of communication management service defined at national level.")]
    OtherNational = NetworkManagementTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of network management service defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_-ZDWwlWQEeeiG_nL4vgKnQ")]
    [Description(@"Other type of network management service defined at private level.")]
    OtherPrivate = NetworkManagementTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Terminate communication at application level.
    /// Encoded/decoded by serializers as "SGNF".
    /// </summary>
    [EnumMember(Value = "SGNF")]
    [IsoId("_-iRkMlWQEeeiG_nL4vgKnQ")]
    [Description(@"Terminate communication at application level.")]
    SignOff = NetworkManagementTypeCode.SignOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Establish communication at application level.
    /// Encoded/decoded by serializers as "SGNN".
    /// </summary>
    [EnumMember(Value = "SGNN")]
    [IsoId("_-uCIQlWQEeeiG_nL4vgKnQ")]
    [Description(@"Establish communication at application level.")]
    SignOn = NetworkManagementTypeCode.SignOn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disable receipt of store and forward advice and notification messages.
    /// Encoded/decoded by serializers as "DSFW".
    /// </summary>
    [EnumMember(Value = "DSFW")]
    [IsoId("_eArUkaDEEeihutZpWtx1zA")]
    [Description(@"Disable receipt of store and forward advice and notification messages.")]
    DisableStoreAndForward = NetworkManagementTypeCode.DisableStoreAndForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System condition/target system unavailable
    /// Encoded/decoded by serializers as "TSUN".
    /// </summary>
    [EnumMember(Value = "TSUN")]
    [IsoId("_UTDiccWUEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/target system unavailable|")]
    TargetSystemUnavailable = NetworkManagementTypeCode.TargetSystemUnavailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System condition/message originator's system in backup.
    /// Encoded/decoded by serializers as "MOSB".
    /// </summary>
    [EnumMember(Value = "MOSB")]
    [IsoId("_UaSy4cWUEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/message originator's system in backup.")]
    MessageOriginatorSystemInBackup = NetworkManagementTypeCode.MessageOriginatorSystemInBackup, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System condition/special instruction
    /// Encoded/decoded by serializers as "SPIN".
    /// </summary>
    [EnumMember(Value = "SPIN")]
    [IsoId("_UeFGscWUEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/special instruction")]
    SpecialInstruction = NetworkManagementTypeCode.SpecialInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System condition/initiate alternate routing
    /// Encoded/decoded by serializers as "IART".
    /// </summary>
    [EnumMember(Value = "IART")]
    [IsoId("_UjLCEcWUEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/initiate alternate routing")]
    InitiateAlternateRouting = NetworkManagementTypeCode.InitiateAlternateRouting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clock synchronization
    /// Encoded/decoded by serializers as "SYCL".
    /// </summary>
    [EnumMember(Value = "SYCL")]
    [IsoId("_UuN0ccWUEeiCfKAZkk6ZAQ")]
    [Description(@"Clock synchronization")]
    SynchronizeClock = NetworkManagementTypeCode.SynchronizeClock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disable the receipt of recurring billing.
    /// Encoded/decoded by serializers as "DRBI".
    /// </summary>
    [EnumMember(Value = "DRBI")]
    [IsoId("_majMEekHEemeDPHh-U9b6w")]
    [Description(@"Disable the receipt of recurring billing.")]
    DisableRecurringBilling = NetworkManagementTypeCode.DisableRecurringBilling, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Enable the receipt of recurring billing.
    /// Encoded/decoded by serializers as "ERBI".
    /// </summary>
    [EnumMember(Value = "ERBI")]
    [IsoId("_mmAOIukHEemeDPHh-U9b6w")]
    [Description(@"Enable the receipt of recurring billing.")]
    EnableRecurringBilling = NetworkManagementTypeCode.EnableRecurringBilling, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NetworkManagementType1CodeMetadataExtensions
{
    private static readonly NetworkManagementType1CodeDropdownSource _dropdownSource = new NetworkManagementType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INetworkManagementType1CodeDropdownRow GetMetadata(this NetworkManagementType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



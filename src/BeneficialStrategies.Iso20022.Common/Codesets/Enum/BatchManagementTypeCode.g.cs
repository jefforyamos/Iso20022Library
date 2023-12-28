﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BatchManagementTypeCode.  ISO2002 ID# _Zw7p8FAXEeedyPuM0kK2EQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of batch management activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zw7p8FAXEeedyPuM0kK2EQ")]
[Description(@"Type of batch management activity.")]
[Derivations(typeof(BatchManagementType1Code),typeof(BatchManagementType2Code))]
// External derivations that should be provided by the proper interface are: 
public enum BatchManagementTypeCode
{
    /// <summary>
    /// Acknowledgement requested by the originator to the destination (used with a notification message exclusively).
    /// Encoded/decoded by serializers as "AKRQ".
    /// </summary>
    [EnumMember(Value = "AKRQ")]
    [IsoId("_d1SQMFAXEeedyPuM0kK2EQ")]
    [Description(@"Acknowledgement requested by the originator to the destination (used with a notification message exclusively).")]
    AcknowledgementRequest,
    
    /// <summary>
    /// Acknowledgement response by the destination to the originator (used with a notification message exclusively).
    /// Encoded/decoded by serializers as "AKRP".
    /// </summary>
    [EnumMember(Value = "AKRP")]
    [IsoId("_tIqToFAXEeedyPuM0kK2EQ")]
    [Description(@"Acknowledgement response by the destination to the originator (used with a notification message exclusively).")]
    AcknowledgementResponse,
    
    /// <summary>
    /// End of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as "ENDB".
    /// </summary>
    [EnumMember(Value = "ENDB")]
    [IsoId("_nGqDAFAZEeedyPuM0kK2EQ")]
    [Description(@"End of a collection or batch by the originator (used with a request message exclusively).")]
    End,
    
    /// <summary>
    /// Initiation of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as "STRT".
    /// </summary>
    [EnumMember(Value = "STRT")]
    [IsoId("_2CYbcFAZEeedyPuM0kK2EQ")]
    [Description(@"Initiation of a collection or batch by the originator (used with a request message exclusively).")]
    Start,
    
    /// <summary>
    /// Any other type of batch management transaction defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_9_ol4FAZEeedyPuM0kK2EQ")]
    [Description(@"Any other type of batch management transaction defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Any other type of batch management transaction defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_GEd_AFAaEeedyPuM0kK2EQ")]
    [Description(@"Any other type of batch management transaction defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// A request to resend a batch or collection.
    /// Encoded/decoded by serializers as "RERQ".
    /// </summary>
    [EnumMember(Value = "RERQ")]
    [IsoId("_mMiG8JbzEeuc6pwKtqbEVQ")]
    [Description(@"A request to resend a batch or collection.")]
    ResendRequest,
    
    /// <summary>
    /// Contains a list of batch or collection identifications.
    /// Encoded/decoded by serializers as "IDNT".
    /// </summary>
    [EnumMember(Value = "IDNT")]
    [IsoId("_vZzu0JbzEeuc6pwKtqbEVQ")]
    [Description(@"Contains a list of batch or collection identifications.")]
    IdentificationList,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BatchManagementTypeCodeMetadataExtensions
{
    private static readonly BatchManagementTypeCodeDropdownSource _dropdownSource = new BatchManagementTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBatchManagementTypeCodeDropdownRow GetMetadata(this BatchManagementTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



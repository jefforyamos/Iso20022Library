﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageErrorCode.  ISO2002 ID# _iwO2kPGuEeiGNursv3uE_g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list containing a code that identifies the error condition.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iwO2kPGuEeiGNursv3uE_g")]
[Description(@"Code list containing a code that identifies the error condition.")]
[Derivations(typeof(MessageError1Code))]
// External derivations that should be provided by the proper interface are: 
public enum MessageErrorCode
{
    /// <summary>
    /// Other reason defined at national level to reject a message.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_iwO2n_GuEeiGNursv3uE_g")]
    [Description(@"Other reason defined at national level to reject a message.")]
    OtherNational,
    
    /// <summary>
    /// Other reason to reject a message defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_iwO2mfGuEeiGNursv3uE_g")]
    [Description(@"Other reason to reject a message defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Required data element missing
    /// Encoded/decoded by serializers as "RDEM".
    /// </summary>
    [EnumMember(Value = "RDEM")]
    [IsoId("_iwO2l_GuEeiGNursv3uE_g")]
    [Description(@"Required data element missing")]
    RequiredDataElementMissing,
    
    /// <summary>
    /// Invalid Message Function
    /// Encoded/decoded by serializers as "INMF".
    /// </summary>
    [EnumMember(Value = "INMF")]
    [IsoId("_iwO2mvGuEeiGNursv3uE_g")]
    [Description(@"Invalid Message Function")]
    InvalidMessageFunction,
    
    /// <summary>
    /// Invalid Collection
    /// Encoded/decoded by serializers as "ICOL".
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_iwO2lvGuEeiGNursv3uE_g")]
    [Description(@"Invalid Collection")]
    InvalidCollection,
    
    /// <summary>
    /// Invalid message
    /// Encoded/decoded by serializers as "INME".
    /// </summary>
    [EnumMember(Value = "INME")]
    [IsoId("_iwO2nPGuEeiGNursv3uE_g")]
    [Description(@"Invalid message")]
    InvalidMessage,
    
    /// <summary>
    /// Message Parse Error
    /// Encoded/decoded by serializers as "MEPE".
    /// </summary>
    [EnumMember(Value = "MEPE")]
    [IsoId("_iwO2lPGuEeiGNursv3uE_g")]
    [Description(@"Message Parse Error")]
    MessageParseError,
    
    /// <summary>
    /// Protocol Version
    /// Encoded/decoded by serializers as "PRVE".
    /// </summary>
    [EnumMember(Value = "PRVE")]
    [IsoId("_iwO2nfGuEeiGNursv3uE_g")]
    [Description(@"Protocol Version")]
    ProtocolVersion,
    
    /// <summary>
    /// Error that is not defined in the Message type Error and is not OtherNational or OtherPrivate Error 
    /// Encoded/decoded by serializers as "UDFD".
    /// </summary>
    [EnumMember(Value = "UDFD")]
    [IsoId("_iwO2m_GuEeiGNursv3uE_g")]
    [Description(@"Error that is not defined in the Message type Error and is not OtherNational or OtherPrivate Error ")]
    Undefined,
    
    /// <summary>
    /// Security
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_iwO2nvGuEeiGNursv3uE_g")]
    [Description(@"Security")]
    Security,
    
    /// <summary>
    /// Duplicate Message
    /// Encoded/decoded by serializers as "DUME".
    /// </summary>
    [EnumMember(Value = "DUME")]
    [IsoId("_iwO2kfGuEeiGNursv3uE_g")]
    [Description(@"Duplicate Message")]
    DuplicateMessage,
    
    /// <summary>
    /// Invalid Batch
    /// Encoded/decoded by serializers as "IBAT".
    /// </summary>
    [EnumMember(Value = "IBAT")]
    [IsoId("_iwO2kvGuEeiGNursv3uE_g")]
    [Description(@"Invalid Batch")]
    InvalidBatch,
    
    /// <summary>
    /// Invalid data element length
    /// Encoded/decoded by serializers as "IDEL".
    /// </summary>
    [EnumMember(Value = "IDEL")]
    [IsoId("_4Duz4PGvEeiGNursv3uE_g")]
    [Description(@"Invalid data element length")]
    InvalidDataElementLength,
    
    /// <summary>
    /// Invalid data element value
    /// Encoded/decoded by serializers as "IDEV".
    /// </summary>
    [EnumMember(Value = "IDEV")]
    [IsoId("_CP33wPGwEeiGNursv3uE_g")]
    [Description(@"Invalid data element value")]
    InvalidDataElementValue,
    
    /// <summary>
    /// Invalid data element format
    /// Encoded/decoded by serializers as "IDEF".
    /// </summary>
    [EnumMember(Value = "IDEF")]
    [IsoId("_GQAsYPGwEeiGNursv3uE_g")]
    [Description(@"Invalid data element format")]
    InvalidDataElementFormat,
    
    /// <summary>
    /// Inconsistent data within message
    /// Encoded/decoded by serializers as "IDWM".
    /// </summary>
    [EnumMember(Value = "IDWM")]
    [IsoId("_NQqEoPGwEeiGNursv3uE_g")]
    [Description(@"Inconsistent data within message")]
    InconsistentDataWithinMessage,
    
    /// <summary>
    /// Inconsistent data with related message
    /// Encoded/decoded by serializers as "IDRM".
    /// </summary>
    [EnumMember(Value = "IDRM")]
    [IsoId("_S2HRQPGwEeiGNursv3uE_g")]
    [Description(@"Inconsistent data with related message")]
    InconsistentDataWithRelatedMessage,
    
    /// <summary>
    /// Iterative data error
    /// Encoded/decoded by serializers as "ITDE".
    /// </summary>
    [EnumMember(Value = "ITDE")]
    [IsoId("_YYnQgPGwEeiGNursv3uE_g")]
    [Description(@"Iterative data error")]
    IterativeDataError,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageErrorCodeMetadataExtensions
{
    private static readonly MessageErrorCodeDropdownSource _dropdownSource = new MessageErrorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageErrorCodeDropdownRow GetMetadata(this MessageErrorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



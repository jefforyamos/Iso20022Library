﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MeetingTypeV2Code.  ISO2002 ID# _Oq2Raq7DEemG7MmivSuE5g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of security holders meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Oq2Raq7DEemG7MmivSuE5g")]
[Description(@"Specifies the type of security holders meeting.")]
public enum MeetingTypeV2Code
{
    /// <summary>
    /// Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_Oq2Rc67DEemG7MmivSuE5g")]
    [Description(@"Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.")]
    AMET,
    
    /// <summary>
    /// Specifies a meeting that is not planned in the by laws.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_Oq2RcK7DEemG7MmivSuE5g")]
    [Description(@"Specifies a meeting that is not planned in the by laws.")]
    OMET,
    
    /// <summary>
    /// Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example, approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_Oq2Rb67DEemG7MmivSuE5g")]
    [Description(@"Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example, approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.")]
    XMET,
    
    /// <summary>
    /// Meeting which contains both ordinary and extraordinary resolutions.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_Oq2Rbq7DEemG7MmivSuE5g")]
    [Description(@"Meeting which contains both ordinary and extraordinary resolutions.")]
    MIXD,
    
    /// <summary>
    /// Meeting for a class of assets.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_Oq2RbK7DEemG7MmivSuE5g")]
    [Description(@"Meeting for a class of assets.")]
    CLAS,
    
    /// <summary>
    /// Meeting is the result of a legal proceeding.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_Oq2Ra67DEemG7MmivSuE5g")]
    [Description(@"Meeting is the result of a legal proceeding.")]
    CMET,
    
    /// <summary>
    /// Meeting that takes place as needed that is neither ordinary nor extraordinary.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_Oq2Rca7DEemG7MmivSuE5g")]
    [Description(@"Meeting that takes place as needed that is neither ordinary nor extraordinary.")]
    SPCL,
    
    /// <summary>
    /// Includes annual and ordinary meetings. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example, approval of dividends and directors. These meetings are always issuer initiated.
    /// </summary>
    [EnumMember(Value = "GMET")]
    [IsoId("_Oq2Rcq7DEemG7MmivSuE5g")]
    [Description(@"Includes annual and ordinary meetings. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example, approval of dividends and directors. These meetings are always issuer initiated.")]
    GMET,
    
    /// <summary>
    /// Physical meeting of bond holders.
    /// </summary>
    [EnumMember(Value = "BMET")]
    [IsoId("_Oq2Rba7DEemG7MmivSuE5g")]
    [Description(@"Physical meeting of bond holders.")]
    BMET,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MeetingTypeV2CodeMetadataExtensions
{
    private static readonly MeetingTypeV2CodeDropdownSource _dropdownSource = new MeetingTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMeetingTypeV2CodeDropdownRow GetMetadata(this MeetingTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



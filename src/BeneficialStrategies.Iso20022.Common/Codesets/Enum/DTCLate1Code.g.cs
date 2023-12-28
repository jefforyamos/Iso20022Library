﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCLate1Code.  ISO2002 ID# _1rD7UDL3EeKU9IrkkToqcw_1757333975.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies late announcements.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rD7UDL3EeKU9IrkkToqcw_1757333975")]
[Description(@"Specifies late announcements.")]
[DerivedFrom(typeof(DTCLateCode))]
public enum DTCLate1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LateAnnouncement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1rD7UTL3EeKU9IrkkToqcw_-1281494311")]
    [Description(@"??")]
    LateAnnouncement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LateAnnouncementPending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1rD7UjL3EeKU9IrkkToqcw_-1916526157")]
    [Description(@"??")]
    LateAnnouncementPending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCLate1CodeMetadataExtensions
{
    private static readonly DTCLate1CodeDropdownSource _dropdownSource = new DTCLate1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCLate1CodeDropdownRow GetMetadata(this DTCLate1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


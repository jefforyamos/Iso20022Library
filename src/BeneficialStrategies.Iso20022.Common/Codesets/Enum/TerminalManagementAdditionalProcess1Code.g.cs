﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementAdditionalProcess1Code.  ISO2002 ID# _KUYDl31DEeCF8NjrBemJWQ_1229049347.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Additional process to perform before starting or after a terminal management action by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUYDl31DEeCF8NjrBemJWQ_1229049347")]
[Description(@"Additional process to perform before starting or after a terminal management action by the point of interaction (POI).")]
[DerivedFrom(typeof(TerminalManagementAdditionalProcessCode))]
public enum TerminalManagementAdditionalProcess1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManualConfirmation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KUYDmH1DEeCF8NjrBemJWQ_-1485151029")]
    [Description(@"??")]
    ManualConfirmation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reconciliation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KUh0kH1DEeCF8NjrBemJWQ_361779399")]
    [Description(@"??")]
    Reconciliation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RestartSystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KUh0kX1DEeCF8NjrBemJWQ_1903870501")]
    [Description(@"??")]
    RestartSystem,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementAdditionalProcess1CodeMetadataExtensions
{
    private static readonly TerminalManagementAdditionalProcess1CodeDropdownSource _dropdownSource = new TerminalManagementAdditionalProcess1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementAdditionalProcess1CodeDropdownRow GetMetadata(this TerminalManagementAdditionalProcess1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



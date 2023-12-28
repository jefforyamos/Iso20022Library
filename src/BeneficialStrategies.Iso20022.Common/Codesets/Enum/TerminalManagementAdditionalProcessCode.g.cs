﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementAdditionalProcessCode.  ISO2002 ID# _KUh0kn1DEeCF8NjrBemJWQ_-888899515.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Additional process to perform before starting or after completing a terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUh0kn1DEeCF8NjrBemJWQ_-888899515")]
[Description(@"Additional process to perform before starting or after completing a terminal management action.")]
[Derivations(typeof(TerminalManagementAdditionalProcess1Code))]
// External derivations that should be provided by the proper interface are: 
public enum TerminalManagementAdditionalProcessCode
{
    /// <summary>
    /// Manual confirmation of the merchant before the terminal management action.
    /// Encoded/decoded by serializers as "MANC".
    /// </summary>
    [EnumMember(Value = "MANC")]
    [IsoId("_KUh0k31DEeCF8NjrBemJWQ_1927674034")]
    [Description(@"Manual confirmation of the merchant before the terminal management action.")]
    ManualConfirmation,
    
    /// <summary>
    /// Acquirer reconciliation to be performed before the terminal management action.
    /// Encoded/decoded by serializers as "RCNC".
    /// </summary>
    [EnumMember(Value = "RCNC")]
    [IsoId("_KUh0lH1DEeCF8NjrBemJWQ_-2075335524")]
    [Description(@"Acquirer reconciliation to be performed before the terminal management action.")]
    Reconciliation,
    
    /// <summary>
    /// Restart the system after performing the terminal management action.
    /// Encoded/decoded by serializers as "RSRT".
    /// </summary>
    [EnumMember(Value = "RSRT")]
    [IsoId("_KUh0lX1DEeCF8NjrBemJWQ_-765156131")]
    [Description(@"Restart the system after performing the terminal management action.")]
    RestartSystem,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementAdditionalProcessCodeMetadataExtensions
{
    private static readonly TerminalManagementAdditionalProcessCodeDropdownSource _dropdownSource = new TerminalManagementAdditionalProcessCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementAdditionalProcessCodeDropdownRow GetMetadata(this TerminalManagementAdditionalProcessCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



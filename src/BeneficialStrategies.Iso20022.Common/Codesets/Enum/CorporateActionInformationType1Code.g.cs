﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionInformationType1Code.  ISO2002 ID# _ioVuQCXcEeOFIcNWlDEvdQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of information event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ioVuQCXcEeOFIcNWlDEvdQ")]
[Description(@"Specifies the type of information event.")]
[DerivedFrom(typeof(CorporateActionInformationTypeCode))]
public enum CorporateActionInformationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConferenceCall".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qcrNQSXcEeOFIcNWlDEvdQ")]
    [Description(@"??")]
    ConferenceCall,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionInformationType1CodeMetadataExtensions
{
    private static readonly CorporateActionInformationType1CodeDropdownSource _dropdownSource = new CorporateActionInformationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionInformationType1CodeDropdownRow GetMetadata(this CorporateActionInformationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


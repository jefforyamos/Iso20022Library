﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommunicationMethodCode.  ISO2002 ID# _bAtSYdp-Ed-ak6NoX_4Aeg_-468324815.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Communication method used for the transmission of documents.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bAtSYdp-Ed-ak6NoX_4Aeg_-468324815")]
[Description(@"Communication method used for the transmission of documents.")]
[Derivations(typeof(CommunicationMethod1Code),typeof(CommunicationMethod2Code),typeof(CommunicationMethod3Code),typeof(CommunicationMethod4Code))]
public enum CommunicationMethodCode
{
    /// <summary>
    /// Transmission by Swift (FIN).
    /// Encoded/decoded by serializers as "SWMT".
    /// </summary>
    [EnumMember(Value = "SWMT")]
    [IsoId("_bAtSYtp-Ed-ak6NoX_4Aeg_-197732743")]
    [Description(@"Transmission by Swift (FIN).")]
    SWIFTMT,
    
    /// <summary>
    /// Transmission by SWIFTNET.
    /// Encoded/decoded by serializers as "SWMX".
    /// </summary>
    [EnumMember(Value = "SWMX")]
    [IsoId("_bAtSY9p-Ed-ak6NoX_4Aeg_1254496871")]
    [Description(@"Transmission by SWIFTNET.")]
    SWIFTMX,
    
    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as "FAXI".
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_bAtSZNp-Ed-ak6NoX_4Aeg_-170028534")]
    [Description(@"Transmission by fax.")]
    Fax,
    
    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_bAtSZdp-Ed-ak6NoX_4Aeg_774732420")]
    [Description(@"Transmission by e-mail.")]
    Email,
    
    /// <summary>
    /// Transmission by proprietary method.
    /// Encoded/decoded by serializers as "PROP".
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_bA3DYNp-Ed-ak6NoX_4Aeg_793203993")]
    [Description(@"Transmission by proprietary method.")]
    Proprietary,
    
    /// <summary>
    /// Transmission on line, for example, in a web portal.
    /// Encoded/decoded by serializers as "ONLI".
    /// </summary>
    [EnumMember(Value = "ONLI")]
    [IsoId("_Q3A9kBOvEeKd9pI2QZcqvg_-2002229090")]
    [Description(@"Transmission on line, for example, in a web portal.")]
    Online,
    
    /// <summary>
    /// Transmission by telephone.
    /// Encoded/decoded by serializers as "PHON".
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_Q3KukBOvEeKd9pI2QZcqvg_1649114947")]
    [Description(@"Transmission by telephone.")]
    Phone,
    
    /// <summary>
    /// Transmission by postal service.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_eDMh4BztEeKjsOi3S79ecQ_1026511097")]
    [Description(@"Transmission by postal service.")]
    PostalService,
    
    /// <summary>
    /// Transmission by file transfer.
    /// Encoded/decoded by serializers as "FILE".
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_eDMh4RztEeKjsOi3S79ecQ_-347697344")]
    [Description(@"Transmission by file transfer.")]
    File,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommunicationMethodCodeMetadataExtensions
{
    private static readonly CommunicationMethodCodeDropdownSource _dropdownSource = new CommunicationMethodCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommunicationMethodCodeDropdownRow GetMetadata(this CommunicationMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



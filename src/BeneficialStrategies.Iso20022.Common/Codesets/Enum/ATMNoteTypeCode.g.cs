﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMNoteTypeCode.  ISO2002 ID# _CjsMwIqgEeS4a4abTJTSSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of items the cash-in cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CjsMwIqgEeS4a4abTJTSSw")]
[Description(@"Type of items the cash-in cassette.")]
[Derivations(typeof(ATMNoteType1Code),typeof(ATMNoteType2Code))]
public enum ATMNoteTypeCode
{
    /// <summary>
    /// All fit bank note types.
    /// Encoded/decoded by serializers as "ALLT".
    /// </summary>
    [EnumMember(Value = "ALLT")]
    [IsoId("_GGMqMIqgEeS4a4abTJTSSw")]
    [Description(@"All fit bank note types.")]
    All,
    
    /// <summary>
    /// Detected counterfeit notes.
    /// Encoded/decoded by serializers as "CNTR".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_IqGxYIqgEeS4a4abTJTSSw")]
    [Description(@"Detected counterfeit notes.")]
    Counterfeit,
    
    /// <summary>
    /// All types of fit bank notes specified in an individual list.
    /// Encoded/decoded by serializers as "IDVD".
    /// </summary>
    [EnumMember(Value = "IDVD")]
    [IsoId("_LepVkIqgEeS4a4abTJTSSw")]
    [Description(@"All types of fit bank notes specified in an individual list.")]
    Individual,
    
    /// <summary>
    /// Suspected counterfeit notes.
    /// Encoded/decoded by serializers as "SCNT".
    /// </summary>
    [EnumMember(Value = "SCNT")]
    [IsoId("_N3-kcIqgEeS4a4abTJTSSw")]
    [Description(@"Suspected counterfeit notes.")]
    SuspectedCounterfeit,
    
    /// <summary>
    /// Unfit bank notes (unacceptable quality).
    /// Encoded/decoded by serializers as "UNFT".
    /// </summary>
    [EnumMember(Value = "UNFT")]
    [IsoId("_Q3BIcIqgEeS4a4abTJTSSw")]
    [Description(@"Unfit bank notes (unacceptable quality).")]
    Unfit,
    
    /// <summary>
    /// Fit bank notes.
    /// Encoded/decoded by serializers as "FITN".
    /// </summary>
    [EnumMember(Value = "FITN")]
    [IsoId("_K5jPAIqhEeS4a4abTJTSSw")]
    [Description(@"Fit bank notes.")]
    Fit,
    
    /// <summary>
    /// Fit and unfit bank notes, if fitness cannot be determined.
    /// Encoded/decoded by serializers as "FITU".
    /// </summary>
    [EnumMember(Value = "FITU")]
    [IsoId("_OmVCwIqhEeS4a4abTJTSSw")]
    [Description(@"Fit and unfit bank notes, if fitness cannot be determined.")]
    FitAndUnfit,
    
    /// <summary>
    /// Notes stained by dye pack.
    /// Encoded/decoded by serializers as "NTRL".
    /// </summary>
    [EnumMember(Value = "NTRL")]
    [IsoId("_RZ4vgIqhEeS4a4abTJTSSw")]
    [Description(@"Notes stained by dye pack.")]
    Neutralised,
    
    /// <summary>
    /// Suspect notes.
    /// Encoded/decoded by serializers as "SPCT".
    /// </summary>
    [EnumMember(Value = "SPCT")]
    [IsoId("_T9gi0IqhEeS4a4abTJTSSw")]
    [Description(@"Suspect notes.")]
    Suspect,
    
    /// <summary>
    /// Unrecognised notes.
    /// Encoded/decoded by serializers as "UNRG".
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_XNiJIIqhEeS4a4abTJTSSw")]
    [Description(@"Unrecognised notes.")]
    Unrecognised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMNoteTypeCodeMetadataExtensions
{
    private static readonly ATMNoteTypeCodeDropdownSource _dropdownSource = new ATMNoteTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMNoteTypeCodeDropdownRow GetMetadata(this ATMNoteTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



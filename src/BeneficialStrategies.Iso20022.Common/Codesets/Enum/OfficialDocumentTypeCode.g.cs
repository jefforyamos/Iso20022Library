﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OfficialDocumentTypeCode.  ISO2002 ID# _6Y3R0HhNEee6_vnrijrKgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Official document type used for identification or authentication
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Y3R0HhNEee6_vnrijrKgg")]
[Description(@"Official document type used for identification or authentication")]
[Derivations(typeof(OfficialDocumentType1Code))]
public enum OfficialDocumentTypeCode
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "ARNU".
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_ClTHwHhOEee6_vnrijrKgg")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistration,
    
    /// <summary>
    /// Travel authorisation assigned by a government agency (e.g. ESTA, etc.)
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_Mv5TgHhOEee6_vnrijrKgg")]
    [Description(@"Travel authorisation assigned by a government agency (e.g. ESTA, etc.)")]
    Authorisation,
    
    /// <summary>
    /// Diplomatic passport or travel document.
    /// Encoded/decoded by serializers as "DIPL".
    /// </summary>
    [EnumMember(Value = "DIPL")]
    [IsoId("_V7an4HhOEee6_vnrijrKgg")]
    [Description(@"Diplomatic passport or travel document.")]
    Diplomatic,
    
    /// <summary>
    /// Driving license.
    /// Encoded/decoded by serializers as "DVLC".
    /// </summary>
    [EnumMember(Value = "DVLC")]
    [IsoId("_gPFQEHhOEee6_vnrijrKgg")]
    [Description(@"Driving license.")]
    DrivingLicense,
    
    /// <summary>
    /// Europol-issued travel or related document.
    /// Encoded/decoded by serializers as "EURO".
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_lEbOYHhOEee6_vnrijrKgg")]
    [Description(@"Europol-issued travel or related document.")]
    Europol,
    
    /// <summary>
    /// Identity card.
    /// Encoded/decoded by serializers as "IDEN".
    /// </summary>
    [EnumMember(Value = "IDEN")]
    [IsoId("_t7mqcHhOEee6_vnrijrKgg")]
    [Description(@"Identity card.")]
    IdentityCard,
    
    /// <summary>
    /// Internal travel document.
    /// Encoded/decoded by serializers as "INTE".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_57UkwHhOEee6_vnrijrKgg")]
    [Description(@"Internal travel document.")]
    Internal,
    
    /// <summary>
    /// Interpol-issued travel or related document 
    /// Encoded/decoded by serializers as "INPO".
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_E3-fkHhPEee6_vnrijrKgg")]
    [Description(@"Interpol-issued travel or related document ")]
    Interpol,
    
    /// <summary>
    /// Emergency travel or related document.
    /// Encoded/decoded by serializers as "LZPR".
    /// </summary>
    [EnumMember(Value = "LZPR")]
    [IsoId("_QS7f8HhPEee6_vnrijrKgg")]
    [Description(@"Emergency travel or related document.")]
    Laissezpasser,
    
    /// <summary>
    /// Passport.
    /// Encoded/decoded by serializers as "PASS".
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_cq_o0HhPEee6_vnrijrKgg")]
    [Description(@"Passport.")]
    Passport,
    
    /// <summary>
    /// Permit.
    /// Encoded/decoded by serializers as "PERM".
    /// </summary>
    [EnumMember(Value = "PERM")]
    [IsoId("_iDTKQHhPEee6_vnrijrKgg")]
    [Description(@"Permit.")]
    Permit,
    
    /// <summary>
    /// Travel or related document issued to refugees.
    /// Encoded/decoded by serializers as "REFU".
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_s88NUHhPEee6_vnrijrKgg")]
    [Description(@"Travel or related document issued to refugees.")]
    Refugee,
    
    /// <summary>
    /// Visa issued by a government or related authority.
    /// Encoded/decoded by serializers as "VISA".
    /// </summary>
    [EnumMember(Value = "VISA")]
    [IsoId("_zKbqUHhPEee6_vnrijrKgg")]
    [Description(@"Visa issued by a government or related authority.")]
    PassportVisa,
    
    /// <summary>
    /// Other type of official document defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_5XGA4HhPEee6_vnrijrKgg")]
    [Description(@"Other type of official document defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of official document defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("__UVbYHhPEee6_vnrijrKgg")]
    [Description(@"Other type of official document defined at private level.")]
    OtherPrivate,
    
}

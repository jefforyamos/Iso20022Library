﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerAssignerCode.  ISO2002 ID# _Q2RBIFyxEeeve7Je9cXtkQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party in charge of assigning the identification of the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q2RBIFyxEeeve7Je9cXtkQ")]
[Description(@"Party in charge of assigning the identification of the customer.")]
[Derivations(typeof(CustomerAssigner1Code))]
public enum CustomerAssignerCode
{
    /// <summary>
    /// Travel agency assigning an identification.
    /// Encoded/decoded by serializers as "TRAY".
    /// </summary>
    [EnumMember(Value = "TRAY")]
    [IsoId("_eW7w0FyxEeeve7Je9cXtkQ")]
    [Description(@"Travel agency assigning an identification.")]
    TravelAgency,
    
    /// <summary>
    /// Legal authority assigning an identification.
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_i-GwQFyxEeeve7Je9cXtkQ")]
    [Description(@"Legal authority assigning an identification.")]
    Authority,
    
    /// <summary>
    /// Company for which the customer is on duty.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_2ND4cFyxEeeve7Je9cXtkQ")]
    [Description(@"Company for which the customer is on duty.")]
    Customer,
    
    /// <summary>
    /// Company assigning an identification to a customer.
    /// Encoded/decoded by serializers as "CRCY".
    /// </summary>
    [EnumMember(Value = "CRCY")]
    [IsoId("__X0X0FyxEeeve7Je9cXtkQ")]
    [Description(@"Company assigning an identification to a customer.")]
    Company,
    
    /// <summary>
    /// On file identification.
    /// Encoded/decoded by serializers as "ONFL".
    /// </summary>
    [EnumMember(Value = "ONFL")]
    [IsoId("_FuHykFyyEeeve7Je9cXtkQ")]
    [Description(@"On file identification.")]
    OnFile,
    
    /// <summary>
    /// Other party assigning an identification.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_JVBAwFyyEeeve7Je9cXtkQ")]
    [Description(@"Other party assigning an identification.")]
    Other,
    
}

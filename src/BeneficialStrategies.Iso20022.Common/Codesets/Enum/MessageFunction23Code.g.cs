﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction23Code.  ISO2002 ID# _DZ7GgFULEeetiruPyDPo0Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies messages related to a network management process.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DZ7GgFULEeetiruPyDPo0Q")]
[Description(@"Identifies messages related to a network management process.|ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction23Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. 
    /// Encoded/decoded by serializers as "ADVC".
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_W52kcemuEemNVKPwszFC-A")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. ")]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as "REQU".
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_YVDXIemuEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
    
}

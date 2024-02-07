﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ATMCommandParameters3Choice.  ISO2002 ID# _hk_BUV2aEeekzJIz1JxYSQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specific parameters attached to an ATM command.
/// </summary>
[KnownType(typeof(ATMCommandParameters3Choice.ATMRequiredGlobalStatus))]
[KnownType(typeof(ATMCommandParameters3Choice.ExpectedMessageFunction))]
[KnownType(typeof(ATMCommandParameters3Choice.RequiredConfigurationParameter))]
[KnownType(typeof(ATMCommandParameters3Choice.RequiredSecurityScheme))]
[KnownType(typeof(ATMCommandParameters3Choice.SecurityDevice))]
[KnownType(typeof(ATMCommandParameters3Choice.Key))]
public abstract partial record ATMCommandParameters3Choice_ : IIsoXmlSerilizable<ATMCommandParameters3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ATMCommandParameters3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ATMReqrdGblSts" => ATMCommandParameters3Choice.ATMRequiredGlobalStatus.Deserialize(elementWithPayload),
             "XpctdMsgFctn" => ATMCommandParameters3Choice.ExpectedMessageFunction.Deserialize(elementWithPayload),
             "ReqrdCfgtnParam" => ATMCommandParameters3Choice.RequiredConfigurationParameter.Deserialize(elementWithPayload),
             "ReqrdSctySchme" => ATMCommandParameters3Choice.RequiredSecurityScheme.Deserialize(elementWithPayload),
             "SctyDvc" => ATMCommandParameters3Choice.SecurityDevice.Deserialize(elementWithPayload),
             "Key" => ATMCommandParameters3Choice.Key.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ATMCommandParameters3Choice choice.")
        };
    }
}

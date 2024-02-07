﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChargesAccount.  ISO2002 ID# _XY_k0Np-Ed-ak6NoX_4Aeg_-1562428108.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Account9Choice;

/// <summary>
/// Account to be used for charges if different from the account for payment.
/// </summary>
public partial record ChargesAccount : Account9Choice_
     , IIsoXmlSerilizable<ChargesAccount>
{
    #nullable enable
    
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
    }
    public static new ChargesAccount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

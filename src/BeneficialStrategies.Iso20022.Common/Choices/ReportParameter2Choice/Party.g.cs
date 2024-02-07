﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Party.  ISO2002 ID# _U1-1gNp-Ed-ak6NoX_4Aeg_-922147102.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ReportParameter2Choice;

/// <summary>
/// Party for which the estimated cash flow is being reported.
/// </summary>
public partial record Party : ReportParameter2Choice_
     , IIsoXmlSerilizable<Party>
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
    public static new Party Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _qTHeLSAdEeuyDZ-ukt4YRg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus29Choice;

/// <summary>
/// Proprietary status.
/// </summary>
public partial record Proprietary : SettlementStatus29Choice_
     , IIsoXmlSerilizable<Proprietary>
{
    #nullable enable
    
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification47 ProprietaryStatus { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason5? ProprietaryReason { get; init; } 
    
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
        writer.WriteStartElement(null, "PrtrySts", xmlNamespace );
        ProprietaryStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProprietaryReason is ProprietaryReason5 ProprietaryReasonValue)
        {
            writer.WriteStartElement(null, "PrtryRsn", xmlNamespace );
            ProprietaryReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Proprietary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _2sTZ-Qd3Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus35Choice;

/// <summary>
/// Provides a proprietary status and a proprietary reason of the processing status of the trade.
/// </summary>
public partial record ProprietaryStatus : MatchingStatus35Choice_
     , IIsoXmlSerilizable<ProprietaryStatus>
{
    #nullable enable
    
    public required GenericIdentification30 Value { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason4? ProprietaryReason { get; init; } 
    
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
        Value.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProprietaryReason is ProprietaryReason4 ProprietaryReasonValue)
        {
            writer.WriteStartElement(null, "PrtryRsn", xmlNamespace );
            ProprietaryReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new ProprietaryStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

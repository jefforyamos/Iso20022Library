﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonDeliverableForwardConditions2.  ISO2002 ID# _dPfNQaZqEea16Jw8SEVrDQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the opening and valuation conditions for the non deliverable forward.
/// </summary>
public partial record NonDeliverableForwardConditions2
     : IIsoXmlSerilizable<NonDeliverableForwardConditions2>
{
    #nullable enable
    
    /// <summary>
    /// Provides the opening information associated with an NDF trade.
    /// </summary>
    public required OpeningConditions1 OpeningConditions { get; init; } 
    /// <summary>
    /// Provides the additional information for an NDF as supplied on a fixing instruction.
    /// </summary>
    public FixingConditions1? FixingConditions { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "OpngConds", xmlNamespace );
        OpeningConditions.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FixingConditions is FixingConditions1 FixingConditionsValue)
        {
            writer.WriteStartElement(null, "FxgConds", xmlNamespace );
            FixingConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static NonDeliverableForwardConditions2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

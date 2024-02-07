﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatusAdvice.  ISO2002 ID# _CEn-0fJlEd-DocZblYEqZw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement3Choice;

/// <summary>
/// Identify the status advice and the transaction for which the status advice was requested.
/// </summary>
public partial record StatusAdvice : StatusOrStatement3Choice_
     , IIsoXmlSerilizable<StatusAdvice>
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    public required DocumentNumber1Choice_ Number { get; init; } 
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    public Identification7? References { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _D2Ul9fJlEd-DocZblYEqZw
    
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
        writer.WriteStartElement(null, "Nb", xmlNamespace );
        Number.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize References, multiplicity Unknown
    }
    public static new StatusAdvice Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

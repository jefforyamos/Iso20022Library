﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerClearingSystemIdentification1.  ISO2002 ID# _XaEtifWfEemtd4wHZYvFUQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the clearing system identification.
/// </summary>
public partial record TrackerClearingSystemIdentification1
     : IIsoXmlSerilizable<TrackerClearingSystemIdentification1>
{
    #nullable enable
    
    /// <summary>
    /// Infrastructure through which the payment instruction is processed, as published in an external clearing system identification code list.
    /// </summary>
    public required ExternalCashClearingSystem1Code Code { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        writer.WriteValue(Code.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static TrackerClearingSystemIdentification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

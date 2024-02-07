﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RIC.  ISO2002 ID# _VcIPgdp-Ed-ak6NoX_4Aeg_-371878008.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification1Choice;

/// <summary>
/// Reuters Identification Code (RIC). A numbering system used within the Reuters system to identify instruments worldwide. The RIC contains an X-character market specific code (can be the CUSIP or EPIC codes) followed by a full stop, then the two-digit ISO country code, eg, IBM in UK is IBM.UK.
/// </summary>
public partial record RIC : SecurityIdentification1Choice_
     , IIsoXmlSerilizable<RIC>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Reuters Identification Code (RIC). A numbering system used within the Reuters system to identify instruments worldwide. The RIC contains an X-character market specific code (can be the CUSIP or EPIC codes) followed by a full stop, then the two-digit ISO country code, for example, IBM in UK is IBM.UK.
    /// </summary>
    public required IsoRICIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "RIC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRICIdentifier(Value)); // data type RICIdentifier System.String
        writer.WriteEndElement();
    }
    public static new RIC Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

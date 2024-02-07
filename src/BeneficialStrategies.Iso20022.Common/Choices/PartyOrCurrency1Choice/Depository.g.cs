﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Depository.  ISO2002 ID# _o-ev0lhDEeOMYfRGLS0NbA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrCurrency1Choice;

/// <summary>
/// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
/// </summary>
public partial record Depository : PartyOrCurrency1Choice_
     , IIsoXmlSerilizable<Depository>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification75Choice_ PartyIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "PtyId", xmlNamespace );
        PartyIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProcessingIdentification is IsoMax35Text ProcessingIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessingIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Depository Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

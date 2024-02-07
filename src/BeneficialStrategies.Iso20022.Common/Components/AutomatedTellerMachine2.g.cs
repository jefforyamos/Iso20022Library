﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AutomatedTellerMachine2.  ISO2002 ID# _X5F2IYp2EeS3NqNpgnMh2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM information.
/// </summary>
public partial record AutomatedTellerMachine2
     : IIsoXmlSerilizable<AutomatedTellerMachine2>
{
    #nullable enable
    
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    public IsoMax35Text? SequenceNumber { get; init; } 
    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    public ActiveCurrencyCode? BaseCurrency { get; init; } 
    /// <summary>
    /// Location of the ATM.
    /// </summary>
    public PostalAddress17? Location { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (AdditionalIdentification is IsoMax35Text AdditionalIdentificationValue)
        {
            writer.WriteStartElement(null, "AddtlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AdditionalIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SequenceNumber is IsoMax35Text SequenceNumberValue)
        {
            writer.WriteStartElement(null, "SeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SequenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (BaseCurrency is ActiveCurrencyCode BaseCurrencyValue)
        {
            writer.WriteStartElement(null, "BaseCcy", xmlNamespace );
            writer.WriteValue(BaseCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Location is PostalAddress17 LocationValue)
        {
            writer.WriteStartElement(null, "Lctn", xmlNamespace );
            LocationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AutomatedTellerMachine2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

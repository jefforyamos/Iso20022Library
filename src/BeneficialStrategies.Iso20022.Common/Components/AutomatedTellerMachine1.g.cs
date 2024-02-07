﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AutomatedTellerMachine1.  ISO2002 ID# _4kERQIn3EeShMpas3885ww.
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
public partial record AutomatedTellerMachine1
     : IIsoXmlSerilizable<AutomatedTellerMachine1>
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
    public required ActiveCurrencyCode BaseCurrency { get; init; } 
    /// <summary>
    /// Location of the ATM.
    /// </summary>
    public PostalAddress17? Location { get; init; } 
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    public TransactionEnvironment2Code? LocationCategory { get; init; } 
    /// <summary>
    /// Capabilities of the ATM terminal performing the transaction.
    /// </summary>
    public PointOfInteractionCapabilities5? Capabilities { get; init; } 
    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    public ATMEquipment1? Equipment { get; init; } 
    
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
        writer.WriteStartElement(null, "BaseCcy", xmlNamespace );
        writer.WriteValue(BaseCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        if (Location is PostalAddress17 LocationValue)
        {
            writer.WriteStartElement(null, "Lctn", xmlNamespace );
            LocationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocationCategory is TransactionEnvironment2Code LocationCategoryValue)
        {
            writer.WriteStartElement(null, "LctnCtgy", xmlNamespace );
            writer.WriteValue(LocationCategoryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Capabilities is PointOfInteractionCapabilities5 CapabilitiesValue)
        {
            writer.WriteStartElement(null, "Cpblties", xmlNamespace );
            CapabilitiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Equipment is ATMEquipment1 EquipmentValue)
        {
            writer.WriteStartElement(null, "Eqpmnt", xmlNamespace );
            EquipmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AutomatedTellerMachine1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cardholder20.  ISO2002 ID# _bB_-AHDeEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the cardholder.
/// </summary>
public partial record Cardholder20
     : IIsoXmlSerilizable<Cardholder20>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    public PersonIdentification15? Identification { get; init; } 
    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    public IsoMax45Text? Name { get; init; } 
    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    public LanguageCode? Language { get; init; } 
    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    public PostalAddress22? BillingAddress { get; init; } 
    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    public PostalAddress22? ShippingAddress { get; init; } 
    /// <summary>
    /// Identification of the trip.
    /// </summary>
    public IsoMax35Text? TripNumber { get; init; } 
    /// <summary>
    /// Information related to the vehicle used for the transaction.
    /// </summary>
    public Vehicle1? Vehicle { get; init; } 
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    public CardholderAuthentication16? Authentication { get; init; } 
    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    public IsoMax70Text? PersonalData { get; init; } 
    /// <summary>
    /// Data related to the mobile of stakeholder.
    /// </summary>
    public MobileData5? MobileData { get; init; } 
    
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
        if (Identification is PersonIdentification15 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Name is IsoMax45Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax45Text(NameValue)); // data type Max45Text System.String
            writer.WriteEndElement();
        }
        if (Language is LanguageCode LanguageValue)
        {
            writer.WriteStartElement(null, "Lang", xmlNamespace );
            writer.WriteValue(LanguageValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BillingAddress is PostalAddress22 BillingAddressValue)
        {
            writer.WriteStartElement(null, "BllgAdr", xmlNamespace );
            BillingAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ShippingAddress is PostalAddress22 ShippingAddressValue)
        {
            writer.WriteStartElement(null, "ShppgAdr", xmlNamespace );
            ShippingAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TripNumber is IsoMax35Text TripNumberValue)
        {
            writer.WriteStartElement(null, "TripNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TripNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Vehicle is Vehicle1 VehicleValue)
        {
            writer.WriteStartElement(null, "Vhcl", xmlNamespace );
            VehicleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Authentication is CardholderAuthentication16 AuthenticationValue)
        {
            writer.WriteStartElement(null, "Authntcn", xmlNamespace );
            AuthenticationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionVerificationResult is TransactionVerificationResult4 TransactionVerificationResultValue)
        {
            writer.WriteStartElement(null, "TxVrfctnRslt", xmlNamespace );
            TransactionVerificationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PersonalData is IsoMax70Text PersonalDataValue)
        {
            writer.WriteStartElement(null, "PrsnlData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(PersonalDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (MobileData is MobileData5 MobileDataValue)
        {
            writer.WriteStartElement(null, "MobData", xmlNamespace );
            MobileDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Cardholder20 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

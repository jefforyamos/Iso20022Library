﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCustomer4.  ISO2002 ID# _I2rJ8a14EeWMg5rOByfExw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer involved in a withdrawal transaction.
/// </summary>
public partial record ATMCustomer4
     : IIsoXmlSerilizable<ATMCustomer4>
{
    #nullable enable
    
    /// <summary>
    /// Profile of the customer selected to perform the transaction.
    /// </summary>
    public ATMCustomerProfile4? Profile { get; init; } 
    /// <summary>
    /// Language selected by the customer at the ATM for the customer session. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    public LanguageCode? SelectedLanguage { get; init; } 
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the customer and its card.
    /// </summary>
    public CardholderAuthentication8? Authentication { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _JDfd9a14EeWMg5rOByfExw
    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    public TransactionVerificationResult5? AuthenticationResult { get; init; } 
    
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
        if (Profile is ATMCustomerProfile4 ProfileValue)
        {
            writer.WriteStartElement(null, "Prfl", xmlNamespace );
            ProfileValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SelectedLanguage is LanguageCode SelectedLanguageValue)
        {
            writer.WriteStartElement(null, "SelctdLang", xmlNamespace );
            writer.WriteValue(SelectedLanguageValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        // Not sure how to serialize Authentication, multiplicity Unknown
        if (AuthenticationResult is TransactionVerificationResult5 AuthenticationResultValue)
        {
            writer.WriteStartElement(null, "AuthntcnRslt", xmlNamespace );
            AuthenticationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMCustomer4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

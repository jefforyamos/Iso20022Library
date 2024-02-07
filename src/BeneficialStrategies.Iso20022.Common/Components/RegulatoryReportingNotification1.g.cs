﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegulatoryReportingNotification1.  ISO2002 ID# _c-VXQDmyEeWDb47rJ6ki4Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the regulatory notification.
/// </summary>
public partial record RegulatoryReportingNotification1
     : IIsoXmlSerilizable<RegulatoryReportingNotification1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the transaction notification.
    /// </summary>
    public required IsoMax35Text TransactionNotificationIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    public required PartyIdentification77 AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 AccountServicer { get; init; } 
    /// <summary>
    /// Certificate against which all currency control transactions are registered.
    /// </summary>
    public TransactionCertificate1? TransactionCertificate { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _YGMKUTm3EeWDb47rJ6ki4Q
    
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
        writer.WriteStartElement(null, "TxNtfctnId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionNotificationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
        AccountOwner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
        AccountServicer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize TransactionCertificate, multiplicity Unknown
    }
    public static RegulatoryReportingNotification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

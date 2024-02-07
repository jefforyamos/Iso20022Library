﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyServerData1.  ISO2002 ID# _0ZN1QNxLEeioifFt1dhnJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the loyalty server during a loyalty transaction.
/// </summary>
public partial record LoyaltyServerData1
     : IIsoXmlSerilizable<LoyaltyServerData1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the loyalty Server.
    /// </summary>
    public IsoMax35Text? LoyaltyServerIdentification { get; init; } 
    /// <summary>
    /// Approval code assigned to a loyalty transaction by the Server.
    /// </summary>
    public IsoMin6Max8Text? ApprovalCode { get; init; } 
    /// <summary>
    /// Identification of the Loyalty transaction in an unambiguous way.
    /// </summary>
    public TransactionIdentifier1? LoyaltyTransactionIdentification { get; init; } 
    /// <summary>
    /// Identifier of a reconciliation period with a payment or loyalty host.
    /// </summary>
    public IsoMax35Text? HostReconciliationIdentification { get; init; } 
    
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
        if (LoyaltyServerIdentification is IsoMax35Text LoyaltyServerIdentificationValue)
        {
            writer.WriteStartElement(null, "LltySvrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LoyaltyServerIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ApprovalCode is IsoMin6Max8Text ApprovalCodeValue)
        {
            writer.WriteStartElement(null, "ApprvlCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin6Max8Text(ApprovalCodeValue)); // data type Min6Max8Text System.String
            writer.WriteEndElement();
        }
        if (LoyaltyTransactionIdentification is TransactionIdentifier1 LoyaltyTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "LltyTxId", xmlNamespace );
            LoyaltyTransactionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HostReconciliationIdentification is IsoMax35Text HostReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "HstRcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(HostReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static LoyaltyServerData1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

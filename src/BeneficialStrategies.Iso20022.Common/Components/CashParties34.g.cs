﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashParties34.  ISO2002 ID# _zimYa7XEEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies cash parties in the framework of a corporate action event.
/// </summary>
public partial record CashParties34
     : IIsoXmlSerilizable<CashParties34>
{
    #nullable enable
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public PartyIdentificationAndAccount162? Creditor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public PartyIdentificationAndAccount172? CreditorAgent { get; init; } 
    /// <summary>
    /// Party that has reimbursed the account owner with funds to which they were legally entitled.
    /// </summary>
    public PartyIdentificationAndAccount162? MarketClaimCounterparty { get; init; } 
    
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
        if (Creditor is PartyIdentificationAndAccount162 CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is PartyIdentificationAndAccount172 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketClaimCounterparty is PartyIdentificationAndAccount162 MarketClaimCounterpartyValue)
        {
            writer.WriteStartElement(null, "MktClmCtrPty", xmlNamespace );
            MarketClaimCounterpartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashParties34 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

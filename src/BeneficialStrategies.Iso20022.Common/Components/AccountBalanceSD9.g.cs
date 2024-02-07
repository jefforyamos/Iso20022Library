﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountBalanceSD9.  ISO2002 ID# _qOfHUZFCEeanIpS4qvJ1tw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
public partial record AccountBalanceSD9
     : IIsoXmlSerilizable<AccountBalanceSD9>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    /// <summary>
    /// Balance that has been accepted by the issuer / agent for payment.
    /// </summary>
    public SignedQuantityFormat9? AcceptedBalance { get; init; } 
    /// <summary>
    /// Balance that has not been accepted by issuer / agent for payment.
    /// </summary>
    public SignedQuantityFormat9? UnacceptedBalance { get; init; } 
    /// <summary>
    /// For Rights Subscription events, total number of oversubscribed units applicable to the payment or the subscription charge.
    /// </summary>
    public SignedQuantityFormat9? OversubscriptionBalance { get; init; } 
    
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
        writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndName)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (OriginalBalance is SignedQuantityFormat9 OriginalBalanceValue)
        {
            writer.WriteStartElement(null, "OrgnlBal", xmlNamespace );
            OriginalBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnpledgedBalance is SignedQuantityFormat9 UnpledgedBalanceValue)
        {
            writer.WriteStartElement(null, "UpldgdBal", xmlNamespace );
            UnpledgedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentUnpledgedBalance is SignedQuantityFormat9 InvestmentUnpledgedBalanceValue)
        {
            writer.WriteStartElement(null, "InvstmtUpldgdBal", xmlNamespace );
            InvestmentUnpledgedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentPledgedBalance is SignedQuantityFormat9 InvestmentPledgedBalanceValue)
        {
            writer.WriteStartElement(null, "InvstmtPldgdBal", xmlNamespace );
            InvestmentPledgedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AcceptedBalance is SignedQuantityFormat9 AcceptedBalanceValue)
        {
            writer.WriteStartElement(null, "AccptdBal", xmlNamespace );
            AcceptedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnacceptedBalance is SignedQuantityFormat9 UnacceptedBalanceValue)
        {
            writer.WriteStartElement(null, "UaccptdBal", xmlNamespace );
            UnacceptedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OversubscriptionBalance is SignedQuantityFormat9 OversubscriptionBalanceValue)
        {
            writer.WriteStartElement(null, "OvrsbcptBal", xmlNamespace );
            OversubscriptionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountBalanceSD9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

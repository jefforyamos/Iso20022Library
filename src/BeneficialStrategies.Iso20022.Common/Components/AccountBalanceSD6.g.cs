﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountBalanceSD6.  ISO2002 ID# _pAInE3oAEeO2o_OAyvnbZw.
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
public partial record AccountBalanceSD6
     : IIsoXmlSerilizable<AccountBalanceSD6>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    public SignedQuantityFormat4? OriginalBalance { get; init; } 
    /// <summary>
    /// Adjusted position held in a security that is subject to redemption call.
    /// </summary>
    public SignedQuantityFormat4? AdjustedBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    public SignedQuantityFormat4? UnpledgedBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    public SignedQuantityFormat4? InvestmentUnpledgedBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    public SignedQuantityFormat4? InvestmentPledgedBalance { get; init; } 
    
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
        if (OriginalBalance is SignedQuantityFormat4 OriginalBalanceValue)
        {
            writer.WriteStartElement(null, "OrgnlBal", xmlNamespace );
            OriginalBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdjustedBalance is SignedQuantityFormat4 AdjustedBalanceValue)
        {
            writer.WriteStartElement(null, "AdjstdBal", xmlNamespace );
            AdjustedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnpledgedBalance is SignedQuantityFormat4 UnpledgedBalanceValue)
        {
            writer.WriteStartElement(null, "UpldgdBal", xmlNamespace );
            UnpledgedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentUnpledgedBalance is SignedQuantityFormat4 InvestmentUnpledgedBalanceValue)
        {
            writer.WriteStartElement(null, "InvstmtUpldgdBal", xmlNamespace );
            InvestmentUnpledgedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentPledgedBalance is SignedQuantityFormat4 InvestmentPledgedBalanceValue)
        {
            writer.WriteStartElement(null, "InvstmtPldgdBal", xmlNamespace );
            InvestmentPledgedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountBalanceSD6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

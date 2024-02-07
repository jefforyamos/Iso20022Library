﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountBalanceSD8.  ISO2002 ID# _doTs95EhEeajS_7NioJdVA.
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
public partial record AccountBalanceSD8
     : IIsoXmlSerilizable<AccountBalanceSD8>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Balance of all uncovered protect instructions across all options.
    /// </summary>
    public SignedQuantityFormat9? UncoveredProtectBalance { get; init; } 
    /// <summary>
    /// Position held in DTC segregated account also called account 18. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    /// <summary>
    /// Position held in DTC segregated account also called account 22. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    /// <summary>
    /// Position held in DTC memo segregated account. This position is eligible for payment.
    /// </summary>
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; } 
    
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
        if (UncoveredProtectBalance is SignedQuantityFormat9 UncoveredProtectBalanceValue)
        {
            writer.WriteStartElement(null, "UcvrdPrtctBal", xmlNamespace );
            UncoveredProtectBalanceValue.Serialize(writer, xmlNamespace);
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
        if (MemoSegregationBalance is SignedQuantityFormat9 MemoSegregationBalanceValue)
        {
            writer.WriteStartElement(null, "MemoSgrtnBal", xmlNamespace );
            MemoSegregationBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountBalanceSD8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

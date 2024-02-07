﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BilateralLimit2.  ISO2002 ID# _gohsMZ-dEee28J7y9KlTWg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics and values set for a bilateral limit, including the counterparty upon which the limit applies.
/// </summary>
public partial record BilateralLimit2
     : IIsoXmlSerilizable<BilateralLimit2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    public required Amount2Choice_ LimitAmount { get; init; } 
    /// <summary>
    /// Specifies if a limit is a debit limit or a credit limit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Balance calculated with regard to one member in the system.
    /// </summary>
    public CashBalance11? BilateralBalance { get; init; } 
    
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
        writer.WriteStartElement(null, "CtrPtyId", xmlNamespace );
        CounterpartyIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LmtAmt", xmlNamespace );
        LimitAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (BilateralBalance is CashBalance11 BilateralBalanceValue)
        {
            writer.WriteStartElement(null, "BilBal", xmlNamespace );
            BilateralBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BilateralLimit2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

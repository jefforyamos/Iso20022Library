﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalTransactions2.  ISO2002 ID# _RpY9sNp-Ed-ak6NoX_4Aeg_-365325273.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide summary information on entries.
/// </summary>
public partial record TotalTransactions2
     : IIsoXmlSerilizable<TotalTransactions2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    public NumberAndSumOfTransactions2? TotalEntries { get; init; } 
    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; } 
    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; } 
    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    public TotalsPerBankTransactionCode2? TotalEntriesPerBankTransactionCode { get; init; } 
    
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
        if (TotalEntries is NumberAndSumOfTransactions2 TotalEntriesValue)
        {
            writer.WriteStartElement(null, "TtlNtries", xmlNamespace );
            TotalEntriesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalCreditEntries is NumberAndSumOfTransactions1 TotalCreditEntriesValue)
        {
            writer.WriteStartElement(null, "TtlCdtNtries", xmlNamespace );
            TotalCreditEntriesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalDebitEntries is NumberAndSumOfTransactions1 TotalDebitEntriesValue)
        {
            writer.WriteStartElement(null, "TtlDbtNtries", xmlNamespace );
            TotalDebitEntriesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalEntriesPerBankTransactionCode is TotalsPerBankTransactionCode2 TotalEntriesPerBankTransactionCodeValue)
        {
            writer.WriteStartElement(null, "TtlNtriesPerBkTxCd", xmlNamespace );
            TotalEntriesPerBankTransactionCodeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TotalTransactions2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

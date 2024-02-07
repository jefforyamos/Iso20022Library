﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialReconciliation2.  ISO2002 ID# _FLdTwSFNEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains financial reconciliation data.
/// </summary>
public partial record FinancialReconciliation2
     : IIsoXmlSerilizable<FinancialReconciliation2>
{
    #nullable enable
    
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    public required ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    /// <summary>
    /// Contains the reconciliation category.
    /// </summary>
    public required ReconciliationCategory1Code Type { get; init; } 
    /// <summary>
    /// Other reconciliation category defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// ISO 8583:87 bit 86,87,88 & 89
    /// ISO 8583:93 bit 86,87,88 ,89,105 & 106
    /// ISO 8583:2003 bit 74-1,74-3,74-5,74-7,74-9 & 74-11
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Number of transactions.
    /// ISO 8583:87 bit 74, 75, 76, 77, 78, 79 & 81
    /// ISO 8583:93 bit 74, 75, 76, 77, 78, 79, 80, 81, 83, 84, 85, 90, 107 & 108
    /// ISO 8583:2003 bit 74-2, 74-4, 74-6, 74-8, 74-10, 74-12, 75-1, 75-2, 75-4, 75-5, 75-6, 76-7, 75-8 & 75-9
    /// </summary>
    public required IsoNumber Count { get; init; } 
    
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
        writer.WriteStartElement(null, "RcncltnImpct", xmlNamespace );
        writer.WriteValue(ReconciliationImpact.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (OtherType is IsoMax35Text OtherTypeValue)
        {
            writer.WriteStartElement(null, "OthrTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(Amount)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cnt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(Count)); // data type Number System.UInt64
        writer.WriteEndElement();
    }
    public static FinancialReconciliation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

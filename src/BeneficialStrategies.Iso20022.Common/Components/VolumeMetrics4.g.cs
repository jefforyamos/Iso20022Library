﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VolumeMetrics4.  ISO2002 ID# _T23LEIMGEeueDJg7fN5MDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on the number of transactions or on market exposures.
/// </summary>
public partial record VolumeMetrics4
     : IIsoXmlSerilizable<VolumeMetrics4>
{
    #nullable enable
    
    /// <summary>
    /// Indication whether reused value is actual or estimated.
    /// </summary>
    public ReuseValue1Choice_? ReuseValue { get; init; } 
    /// <summary>
    /// Provides details on the amount of the cash reinvestment in a given currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ReinvestedCashAmount { get; init; } 
    
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
        if (ReuseValue is ReuseValue1Choice_ ReuseValueValue)
        {
            writer.WriteStartElement(null, "ReuseVal", xmlNamespace );
            ReuseValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReinvestedCashAmount is IsoActiveOrHistoricCurrencyAndAmount ReinvestedCashAmountValue)
        {
            writer.WriteStartElement(null, "RinvstdCshAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(ReinvestedCashAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static VolumeMetrics4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

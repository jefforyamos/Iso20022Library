﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractType8.  ISO2002 ID# _Zj1khQ1HEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract attributes.
/// </summary>
public partial record ContractType8
     : IIsoXmlSerilizable<ContractType8>
{
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    public ProductType4Code? AssetClass { get; init; } 
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    public ProductClassification1Choice_? ProductClassification { get; init; } 
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    public SecurityIdentification18Choice_? ProductIdentification { get; init; } 
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; init; } 
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    public ActiveCurrencyCode? NotionalCurrencyFirstLeg { get; init; } 
    /// <summary>
    /// Other currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    public ActiveCurrencyCode? NotionalCurrencySecondLeg { get; init; } 
    /// <summary>
    /// Specifies the currency to be delivered.
    /// </summary>
    public ActiveCurrencyCode? DeliverableCurrency { get; init; } 
    
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
        if (ContractType is FinancialInstrumentContractType2Code ContractTypeValue)
        {
            writer.WriteStartElement(null, "CtrctTp", xmlNamespace );
            writer.WriteValue(ContractTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AssetClass is ProductType4Code AssetClassValue)
        {
            writer.WriteStartElement(null, "AsstClss", xmlNamespace );
            writer.WriteValue(AssetClassValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ProductClassification is ProductClassification1Choice_ ProductClassificationValue)
        {
            writer.WriteStartElement(null, "PdctClssfctn", xmlNamespace );
            ProductClassificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProductIdentification is SecurityIdentification18Choice_ ProductIdentificationValue)
        {
            writer.WriteStartElement(null, "PdctId", xmlNamespace );
            ProductIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingInstrument is SecurityIdentification34Choice_ UnderlyingInstrumentValue)
        {
            writer.WriteStartElement(null, "UndrlygInstrm", xmlNamespace );
            UnderlyingInstrumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NotionalCurrencyFirstLeg is ActiveCurrencyCode NotionalCurrencyFirstLegValue)
        {
            writer.WriteStartElement(null, "NtnlCcyFrstLeg", xmlNamespace );
            writer.WriteValue(NotionalCurrencyFirstLegValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NotionalCurrencySecondLeg is ActiveCurrencyCode NotionalCurrencySecondLegValue)
        {
            writer.WriteStartElement(null, "NtnlCcyScndLeg", xmlNamespace );
            writer.WriteValue(NotionalCurrencySecondLegValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DeliverableCurrency is ActiveCurrencyCode DeliverableCurrencyValue)
        {
            writer.WriteStartElement(null, "DlvrblCcy", xmlNamespace );
            writer.WriteValue(DeliverableCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static ContractType8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

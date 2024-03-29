using System;
using System.Collections.Generic;
using Department.Base.Infrastructure.Swagger;
using Department.Base.Model.Common;
using Department.Base.Model.Marketing;

namespace Department.Base.Model.Order
{
    /// <summary>
    /// Represents order shipment
    /// </summary>
    [SwaggerSchemaId("OrderShipment")]
    public partial class Shipment
    {
        public Shipment(Currency currency)
        {
            Items = new List<ShipmentItem>();
            Packages = new List<ShipmentPackage>();
            InPayments = new List<PaymentIn>();
            TaxDetails = new List<TaxDetail>();
            ChildrenOperations = new List<Operation>();
            DynamicProperties = new List<DynamicProperty>();
            Currency = currency;

            Price = new Money(currency);
            PriceWithTax = new Money(currency);
            DiscountAmount = new Money(currency);
            DiscountAmountWithTax = new Money(currency);
            ItemsSubtotal = new Money(currency);
            ItemsSubtotalWithTax = new Money(currency);
            TaxTotal = new Money(currency);
            Total = new Money(currency);
            TotalWithTax = new Money(currency);
            Discounts = new List<Discount>();

        }
        public string Title => ShipmentMethodCode;
        public string Handle => ShipmentMethodCode;
        /// <summary>
        /// Customer organization
        /// </summary>
        /// <value>Customer organization</value>
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        public string OrganizationId { get; set; }

        /// <summary>
        /// Fulfillment center where shipment will be handled
        /// </summary>
        /// <value>Fulfillment center where shipment will be handled</value>
        public string FulfillmentCenterName { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentCenterId
        /// </summary>
        public string FulfillmentCenterId { get; set; }

        /// <summary>
        /// Code used for link shipment with external carrier service implementation (FedEx, USPS etc)
        /// </summary>
        /// <value>Code used for link shipment with external carrier service implementation (FedEx, USPS etc)</value>
        public string ShipmentMethodCode { get; set; }

        /// <summary>
        /// Describe some shipment options (Vip, Air, Moment etc)
        /// </summary>
        /// <value>Describe some shipment options (Vip, Air, Moment etc)</value>
        public string ShipmentMethodOption { get; set; }

        /// <summary>
        /// Employee who responsible for handling current shipment
        /// </summary>
        /// <value>Employee who responsible for handling current shipment</value>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets WeightUnit
        /// </summary>
        public string WeightUnit { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// Gets or Sets MeasureUnit
        /// </summary>
        public string MeasureUnit { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        public double? Length { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Information about quantity and order items belongs to current shipment
        /// </summary>
        /// <value>Information about quantity and order items belongs to current shipment</value>
        public IList<ShipmentItem> Items { get; set; }

        /// <summary>
        /// Information about packages belongs to current shipment
        /// </summary>
        /// <value>Information about packages belongs to current shipment</value>
        public IList<ShipmentPackage> Packages { get; set; }

        /// <summary>
        /// Gets or Sets InPayments
        /// </summary>
        public IList<PaymentIn> InPayments { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Gets or Sets TaxDetails
        /// </summary>
        public IList<TaxDetail> TaxDetails { get; set; }

        /// <summary>
        /// Operation type string representation (CustomerOrder, Shipment etc)
        /// </summary>
        /// <value>Operation type string representation (CustomerOrder, Shipment etc)</value>
        public string OperationType { get; set; }

        /// <summary>
        /// Unique user friendly document number (generate automatically based on special algorithm realization)
        /// </summary>
        /// <value>Unique user friendly document number (generate automatically based on special algorithm realization)</value>
        public string Number { get; set; }

        /// <summary>
        /// Flag can be used to refer to a specific order status in a variety of user scenarios with combination of Status\r\n            (Order completion, Shipment send etc)
        /// </summary>
        /// <value>Flag can be used to refer to a specific order status in a variety of user scenarios with combination of Status\r\n            (Order completion, Shipment send etc)</value>
        public bool? IsApproved { get; set; }

        /// <summary>
        /// Current operation status may have any values defined by concrete business process
        /// </summary>
        /// <value>Current operation status may have any values defined by concrete business process</value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Currecy code
        /// </summary>
        /// <value>Currecy code</value>
        public Currency Currency { get; set; }

        /// <summary>
        /// Gets or Sets TaxIncluded
        /// </summary>
        public bool? TaxIncluded { get; set; }

        /// <summary>
        /// Gets or Sets IsCancelled
        /// </summary>
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// Gets or Sets CancelledDate
        /// </summary>
        public DateTime? CancelledDate { get; set; }

        /// <summary>
        /// Gets or Sets CancelReason
        /// </summary>
        public string CancelReason { get; set; }

        /// <summary>
        /// Used for construct hierarchy of operation and represent parent operation id
        /// </summary>
        /// <value>Used for construct hierarchy of operation and represent parent operation id</value>
        public string ParentOperationId { get; set; }

        /// <summary>
        /// Gets or Sets ChildrenOperations
        /// </summary>
        public IList<Operation> ChildrenOperations { get; set; }

        /// <summary>
        /// Used for dynamic properties management, contains object type string
        /// </summary>
        /// <value>Used for dynamic properties management, contains object type string</value>
        public string ObjectType { get; set; }

        /// <summary>
        /// Dynamic properties collections
        /// </summary>
        /// <value>Dynamic properties collections</value>
        public IList<DynamicProperty> DynamicProperties { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public string Id { get; set; }

        public string TaxType { get; set; }
        public Money TaxTotal { get; set; }
        public decimal TaxPercentRate { get; set; }

        public IList<Discount> Discounts { get; set; }

        public Money Price { get; set; }
        public Money PriceWithTax { get; set; }
        public Money Total { get; set; }
        public Money TotalWithTax { get; set; }
        public Money ItemsSubtotal { get; set; }
        public Money ItemsSubtotalWithTax { get; set; }
        public Money DiscountAmount { get; set; }
        public Money DiscountAmountWithTax { get; set; }

    }
}

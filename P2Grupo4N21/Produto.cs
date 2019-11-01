using System.Runtime.Serialization;
using System;

namespace P2Grupo4N21
{
    [DataContract]
    public class produto
    {

        /*
         
            RETORNO JSON DO SERVIDOR
         
         {
    "description":"AGUA MINERAL PASSA QUATRO",
    "gtin":7896984205004,
    "thumbnail":"https://api.cosmos.bluesoft.com.br/assets/product-placeholder-ce4926921923d1e9bc66cd0e1493b49b.png",
    "price":"R$ 1,50",
    "avg_price":1.5,
    "max_price":1.5,
    "min_price":1.5,
    "width":0.0,
    "height":0.0,
    "length":0.0,
    "net_weight":null,
    "gross_weight":null,
    "created_at":"2015-01-14T22:00:00.000-02:00",
    "updated_at":"2019-10-31T22:27:37.000-03:00",
    "barcode_image":"https://api.cosmos.bluesoft.com.br/products/barcode/A7EF44BE081A6E6F7BF234C9A8ED08E8.png",
      
            FIM DO RETORNO JSON DO SERVIDOR
             */

        public produto(string descricao, string cod_barras, string imagen_produto, string valor, string valor_varejo, string valor_maximo, string valor_minimo, string largura, string altura, string comprimento, string peso_liquido, string peso_bruto, string criado, string modificado, string imagen_codigo_barras)
        {
            description = descricao;
            gtin = cod_barras;
            thumbnail = imagen_produto;
            price = valor;
            avg_price = valor_varejo;
            max_price = valor_maximo;
            min_price = valor_minimo;
            width = largura;
            height = altura;
            length = comprimento;
            net_weight = peso_liquido;
            gross_weight = peso_bruto;
            created_at = criado;
            updated_at = modificado;
            barcode_image = imagen_codigo_barras;
        
         }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string gtin { get; set; }

        [DataMember]
        public string thumbnail { get; set; }

        [DataMember]
        public string price { get; set; }

        [DataMember]
        public string avg_price { get; set; }

        [DataMember]
        public string max_price { get; set; }

        [DataMember]
        public string min_price { get; set; }

        [DataMember]
        public string width { get; set; }

        [DataMember]
        public string height { get; set; }

        [DataMember]
        public string length { get; set; }

        [DataMember]
        public string net_weight { get; set; }

        [DataMember]
        public string gross_weight { get; set; }

        [DataMember]
        public string created_at { get; set; }

        [DataMember]
        public string updated_at { get; set; }

        [DataMember]
        public string barcode_image { get; set; }

    }

}

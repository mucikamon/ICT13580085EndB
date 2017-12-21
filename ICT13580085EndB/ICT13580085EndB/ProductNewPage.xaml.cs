using ICT13580085EndB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580085EndB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductNewPage : ContentPage
    {
        Product product;
        public ProductNewPage(Product product=null)
        {
            this.product = product;
          //  titleLabel.Text = product == null ? "เพิ่มสินค้าใหม่" : "แก้ไขข้อมูลสินค้า";
            InitializeComponent();
            submitButton.Clicked += SubmitButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;

            categoryCarPicker.Items.Add("เก๋ง");
            categoryCarPicker.Items.Add("กระบะ");
            categoryCarPicker.Items.Add("ตู้");
            categoryCarPicker.Items.Add("บรรทุก");
            brandCarPicker.Items.Add("โตโยต้า");
            brandCarPicker.Items.Add("ฮอนด้า");
            brandCarPicker.Items.Add("อีซูซุ");
            brandCarPicker.Items.Add("มิตซูบิชิ");
            colorCarPicker.Items.Add("ดำ");
            colorCarPicker.Items.Add("ขาว");
            colorCarPicker.Items.Add("แดง");
            colorCarPicker.Items.Add("น้ำเงิน");
            colorCarPicker.Items.Add("น้ำตาล");
            provincePicker.Items.Add("กทมมีพารากอน");
            provincePicker.Items.Add("นนทบุรีมีทุเรียน");
            provincePicker.Items.Add("เพชรบุรีมีน้ำตาล");
            provincePicker.Items.Add("พัทลุงมีนุ้งนาย");
            if (product != null)
            {
               
                categoryCarPicker.SelectedItem = product.Category;
                brandCarPicker.SelectedItem = product.Brand;
                productGenEntry.Text = product.Gen;
                productYearEntry.Text = product.Years.ToString();
                productMilesEntry.Text = product.Miles.ToString();
                colorCarPicker.SelectedItem = product.Color;
                productDelerEntry.Text = product.Deler;
                productDescriptionEntry.Text = product.Description;
                productPriceEntry.Text = product.Price.ToString();
                provincePicker.SelectedItem = product.Province;
                productTelEntry.Text = product.Tel.ToString();
            }
        }

        async  void SubmitButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");
        if(isOk)
            {
                if (product == null)
                {


                    var product = new Product();
                    product.Category = categoryCarPicker.SelectedItem.ToString();
                    product.Brand = brandCarPicker.SelectedItem.ToString();
                    product.Gen = productGenEntry.Text;
                    product.Years = decimal.Parse(productYearEntry.Text);
                    product.Miles = decimal.Parse(productMilesEntry.Text);
                    product.Color = colorCarPicker.SelectedItem.ToString();
                    product.Deler = productDelerEntry.Text;
                    product.Description = productDescriptionEntry.Text;
                    product.Price = decimal.Parse(productPriceEntry.Text);
                    product.Province = provincePicker.SelectedItem.ToString();
                    product.Tel = decimal.Parse(productTelEntry.Text);
                    var id = App.DbHelper.AddProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ #" + id, "ตกลง");
                }
                else
                {

                    var product = new Product();
                    product.Category = categoryCarPicker.SelectedItem.ToString();
                    product.Brand = brandCarPicker.SelectedItem.ToString();
                    product.Gen = productGenEntry.Text;
                    product.Years = decimal.Parse(productYearEntry.Text);
                    product.Miles = decimal.Parse(productMilesEntry.Text);
                    product.Color = colorCarPicker.SelectedItem.ToString();
                    product.Deler = productDelerEntry.Text;
                    product.Description = productDescriptionEntry.Text;
                    product.Price = decimal.Parse(productPriceEntry.Text);
                    product.Province = provincePicker.SelectedItem.ToString();
                    product.Tel = decimal.Parse(productTelEntry.Text);
                    var id = App.DbHelper.AddProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ #" + id, "ตกลง");
                }
                    await Navigation.PopModalAsync();


            }
        }

        async  void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        
    }
}
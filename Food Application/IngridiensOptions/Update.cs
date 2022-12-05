namespace Food_Application
{
    public class update
    {
        public static async Task<Ingridien> addData(Ingridien _ingridien, Form2 form)
        {
            _ingridien.name = form.NameBox.Text;
            _ingridien.price = Double.Parse(form.PriceBox.Text);

            if (form.MasBox.Text.Length != 0)
            {
                _ingridien.mas = Math.Round(Double.Parse(form.MasBox.Text), 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                _ingridien.quantity = Math.Round(Double.Parse(form.QuantityBox.Text), 2, MidpointRounding.AwayFromZero);
            }
                return _ingridien;

        }
    }
}

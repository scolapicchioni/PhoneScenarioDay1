namespace PhoneScenario.ConsoleApp {
    class GenericList<TheTypeOfTheItemInTheCollection> {
        private TheTypeOfTheItemInTheCollection[] items = new TheTypeOfTheItemInTheCollection[10];
        private int count = 0;

        public int Length {
            get {
                return count;
            }
        }

        public void Add(TheTypeOfTheItemInTheCollection item) {
            items[count] = item;
            count = count + 1;
        }

        public TheTypeOfTheItemInTheCollection ItemAt(int index) {
            return items[index];
        }
    }
}

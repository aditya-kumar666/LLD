using static System.Formats.Asn1.AsnWriter;

namespace CarRentalSystem
{
    public class VehicleRentalSystem
    {
        List<Store> storeList;
        List<User> userList;
        public VehicleRentalSystem(List<Store> stores, List<User> users)
        {
            storeList = stores;
            userList = users;
        }


        public Store getStore(Location location)
        {

            //based on location, we will filter out the Store from storeList.
            return storeList[0];
        }



        //addUsers

        //remove users


        //add stores

        //remove stores

    }
}

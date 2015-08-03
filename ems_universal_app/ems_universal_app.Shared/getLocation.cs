using System;
using System.Collections.Generic;
using System.Text;

namespace ems_universal_app
{
    class getLocation
    {
        public string location { get; set; }
        public double latitude { get; set; }
        public double longtude { get; set; }

public getLocation()
        {
            this.location = "";
             this.latitude = 0.0;
            this.longtude = 0.0;

        }

public string getCurrentLocatino()
        {
            string curentlocation = "tut";
        // do the coding
    
/*            if (e.Parameter == null)
            {
                // Add
                isViewing = false;

                var locator = new Geolocator();
                locator.DesiredAccuracyInMeters = 50;
            }
                else{
                // MUST ENABLE THE LOCATION CAPABILITY!!!
                var position = await locator.GetGeopositionAsync();
                myPoint = position.Coordinate.Point;

            
                     var url = "http://maps.googleapis.com/maps/api/geocode/json?latlng='.trim(latitude).','.trim(longtude).'sensor=false";
		                 var json = @file_get_contents( url ) ;
		                    curentlocation = json_decode( json );
                }*/
             return curentlocation;   
            }

        }
    }


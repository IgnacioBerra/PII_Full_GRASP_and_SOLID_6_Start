
namespace Full_GRASP_And_SOLID
{

    // Implementado por ISP.        
    
    public class RecipeTimerClient : TimerClient 
    {
       public Recipe Recipe{get;set;} 

       
        public RecipeTimerClient(Recipe recipe)
        {
            this.Recipe = recipe;
        }

        //Settea en TRUE el bool Cooked cuando termina el timer
        // indicando asi que se cocinó la receta. 
       public void TimeOut()
       {
            Recipe.Cooked = true;
       }
    }
}
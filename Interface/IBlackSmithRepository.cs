using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmith.Repository.Interface
{
    public interface IBlackSmithRepository<Entity, ID>
    {
        RegisterResult Register(Entity entity);

        UpdateResult Update(Entity entity);

        GetAllResult GetAll();

        FindResult FindById(ID id);

        FindResult FindByEntity(Entity entity);

        ExistResult ExistById(ID id);

        ExistResult ExistByEntity(Entity entity);

        DeleteResult DeleteById(ID id);

        DeleteResult DeleteByEntity(Entity entity);
    }

    public record RegisterResult
    {

    }

    public record UpdateResult
    {

    }

    public record GetAllResult
    {

    }

    public record FindResult
    {

    }

    public record ExistResult
    {

    }

    public record DeleteResult
    {

    }
}
